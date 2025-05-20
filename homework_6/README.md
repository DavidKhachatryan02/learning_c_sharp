### 🚗 **Task 1: Vehicle Registration System**

**Scenario**: You’re building a basic console app for a small vehicle registration office.

#### Requirements:

* Ask the user to enter vehicle details: Brand, Model, Year, Engine Capacity, Owner Name.
* Use appropriate data types for each property.
* Concatenate strings to display the formatted registration record.
* Validate:

  * Year should be >= 1980 and <= current year.
  * Engine Capacity should be > 0.
* If validation fails, display a meaningful message using `if-else` and `logical operators`.
* Use `StringBuilder` to build the display output.
* Bonus: Create 3 vehicle records using a `for` or `while` loop.

---

### 🏦 **Task 2: Simple ATM Simulation**

**Scenario**: You are simulating basic ATM operations via a console.

#### Requirements:

* Start with a fixed account balance (e.g., 10,000).
* Show a menu:

  1. Check balance
  2. Deposit
  3. Withdraw
  4. Exit
* Use `switch-case` or `if-else` to handle user choices.
* Use arithmetic operators to update balance.
* Withdrawals must check for insufficient funds using `comparison and logical operators`.
* Use loops to keep the program running until the user chooses "Exit".
* Use string interpolation to display the balance and messages.

---

### 🛍️ **Task 3: Simple Shopping Cart**

**Scenario**: Simulate a shopping cart system for a small grocery store.

#### Requirements:

* Allow the user to enter product names and prices (up to 5 products).
* Use arrays or lists (if introduced) to store them, or use string variables for a fixed number.
* Calculate the total price using a loop.
* Apply a 10% discount if the total exceeds \$100.
* Use string formatting to display the bill nicely.
* Show final amount after discount.
* Use `StringBuilder` to print the full invoice.

---

### ⏰ **Task 4: Work Shift Scheduler**

**Scenario**: A factory wants to create a weekly shift scheduler.

#### Requirements:

* Ask the user to input:

  * Employee name
  * Day of the week
  * Shift start and end times (use integers for 24hr format)
* Use `if-else` or `switch` to determine:

  * If the shift is "Morning", "Afternoon", or "Night".
  * Warn if the shift is longer than 12 hours.
* Use `?:` (ternary operator) to determine whether the employee has a "Short" or "Long" shift.
* Display the summary using `StringBuilder`.

---

### 👨‍👩‍👧‍👦 **Task 5: Household Budget Tracker**

**Scenario**: Help a family manage their monthly budget.

#### Requirements:

* Ask for:

  * Monthly income
  * Expenses for: rent, groceries, transport, entertainment, other
* Calculate:

  * Total expenses
  * Remaining balance
* Use arithmetic and logical operators to warn if:

  * More than 80% of income is spent
  * Balance is negative
* Use null-coalescing `??` operator to handle optional values like entertainment (e.g., empty input = 0).
* Use operator precedence correctly when calculating the remaining balance.

---

### 💻 Bonus Task: Basic User Login System

**Scenario**: Simulate a login system.

#### Requirements:

* Store a username and password in variables.
* Ask the user to input credentials.
* Compare inputs using equality operators.
* Allow up to 3 attempts using a loop.
* Use null-conditional (`?.`) and null-coalescing (`??`) if using optional middle names or additional data.

---

These tasks:
✅ Integrate Part 1 and Part 2 features
✅ Involve string manipulation, conditionals, loops, operators, and type conversions
✅ Are close to real-life use cases
✅ Encourage practical problem-solving and critical thinking

Would you like me to generate **starter templates or sample outputs** for any of these tasks?