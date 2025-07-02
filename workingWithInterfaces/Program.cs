namespace _classwork
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            IUserService userService = new UserSerive();
            IBankingService bankingService = new BankingService();
            ICustomerSupportService customerSupportService = new CustomerSerive();

            var user = userService.RegisterUser("Email", "name");
            if (user is null)
            {
                customerSupportService.CreateSupportTicket(TicketType.RegisterError, "desc");
                // 400
            }

            var userAccount = bankingService.CreateAccount(user.Id);
            if (userAccount is null)
            {
                customerSupportService.CreateSupportTicket(TicketType.CreateAccountError, user.id, "desc");
            }

            var isTransactionCreated = bankingService.TransferMonay(userAccount.id, rnd.Next(1, 100000), 500m); //TODO toAcc is random number // // returning BOOLEAN
            if (!isTransactionCreated)
            {
                customerSupportService.CreateSupportTicket(TicketType.TransactionError, user.id, "desc");
            }
        }

        public class Ticket
        {
            public int Id { get; }
            public TicketType Type { get; }
            public int? UserId { get; }
            public DateTime CreatedAt { get; }
            public string Desc { get; }
            public bool IsClosed { get; set; }

            public Ticket(TicketType type, int? userId, string desc)
            {
                Random rnd = new Random();

                Id = rnd.Next(1, 100000);
                Type = type;
                UserId = userId;
                Desc = desc;
                CreatedAt = DateTime.Now();
                IsClosed = false;
            }
            public Ticket(TicketType type, string desc) : this(type, null, desc) { }

        }

        interface ICustomerSupportService
        {
            Ticket CreateSupportTicket(TicketType ticketType, int userId, string desc);
            void CloseTicket(int ticketId);
            List<Ticket> GetTickets(int userId);
        }

        public enum TicketType
        {
            RegisterError,
            CreateAccountError,
            TransactionError,
        }

        interface IBankingService
        {
            Account? CreateAccount(int userId);
            bool TransferMonay(int fromId, int ToId, decimal ammount);
        }
        interface IUserService
        {
            User? RegisterUser(string name, string email);
        }
    }
}