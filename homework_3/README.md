📄 C# Practice Tasks: Complex Logic with Nested if Statements
1. 🛫 Airline Baggage Fee Calculator
- Ask the user for baggage weight and class (Economy, Business, First).
- Economy: free up to 20kg, then $10/kg.
- Business: free up to 30kg, then $8/kg.
- First: free up to 40kg, then $5/kg.
- Use nested ifs to determine and print the fee.
2. 🏫 Student Scholarship Eligibility Checker
- Input: GPA, attendance %, and community service hours.
- To qualify: GPA >= 3.5 AND attendance >= 90%
  - If service hours >= 20 → "Full Scholarship"
  - Else if >= 10 → "Half Scholarship"
  - Else → "Academic Scholarship Only"
- Else → "Not Eligible"
3. 🧾 Progressive Tax Calculator
- Ask user for annual income.
- Tax rules:
  - If income > 100,000:
    - First 50k: 10%
    - Next 50k: 20%
    - Remaining: 30%
  - Else if income > 50,000:
    - First 50k: 10%
    - Remaining: 20%
  - Else: 10%
- Calculate and print total tax using nested ifs.
4. 🏢 Job Applicant Filter
- Ask for years of experience, education level (High School, Bachelor, Master), and skill test score.
- If experience >= 5:
  - If education is Master or Bachelor:
    - If score >= 80 → "Highly Eligible"
    - Else if >= 60 → "Eligible"
    - Else → "Needs Improvement"
  - Else → "Education Not Sufficient"
- Else → "Not Enough Experience"
5. 🎟️ Theme Park Ticket Pricing
- Ask for age and ticket type (Standard, Fast Pass).
- Age < 5: Free
- Age 5–12: Standard: $10, Fast Pass: $15
- Age 13–64: Standard: $20, Fast Pass: $30
- Age 65+: Standard: $12, Fast Pass: $18
- Use nested ifs to compute price.
6. 🛒 Bulk Discount Engine
- Input: item price, quantity, customer type (Regular, VIP).
- If quantity > 100:
  - VIP → 20% discount
  - Regular → 10%
- Else if > 50:
  - VIP → 15%
  - Regular → 5%
- Else:
  - VIP → 10%
  - Regular → no discount
- Print final price after discount.
7. 🧑‍🍳 Restaurant Order Surcharge
- Ask for meal type (Breakfast, Lunch, Dinner), delivery or dine-in, and time.
- If delivery:
  - Dinner after 8PM → +$5 surcharge
  - Lunch → +$3
- Else if dine-in:
  - Breakfast before 8AM → +$2 early bird fee
- Else → no surcharge
8. 🏠 Rent Estimator
- Input: city (Tier 1, Tier 2), apartment type (1BHK, 2BHK, 3BHK), and amenities (yes/no).
- Tier 1:
  - 1BHK: $800, 2BHK: $1200, 3BHK: $1600
- Tier 2:
  - 1BHK: $600, 2BHK: $900, 3BHK: $1200
- If amenities = yes → add $100
- Print final rent.
9. 💳 Credit Card Approval System
- Input: income, credit score, age.
- If age >= 21:
  - If income >= 30000:
    - If credit score >= 700 → "Approved"
    - Else if >= 600 → "Approved with Low Limit"
    - Else → "Denied"
  - Else → "Low Income - Denied"
- Else → "Too Young - Denied"
10. 🧠 IQ Level Categorizer
- Input: age group (child, teen, adult) and IQ score.
- Child: 80–110 = Average, >110 = Gifted, <80 = Needs Support
- Teen: 90–120 = Average, >120 = Advanced, <90 = Below Average
- Adult: 100–130 = Normal, >130 = High IQ, <100 = Below Normal
- Use nested ifs to determine level.


📄 C# Practice Tasks: Loops + Decision-Making (if, switch)
1. 🧾 Shopping Cart Price Calculator
- Use: while loop + switch
- Task: Let user add item codes (A: Apple $2, B: Bread $3, C: Cheese $5).
- Use switch to get item price.
- Stop when user enters "done". Print total cost.
2. 🔢 Number Categorizer
- Use: while loop + if-else
- Task: Ask for numbers.
- If < 0 → "Negative", 0 → "Zero", > 0 → "Positive".
- Stop when user types "exit".
3. 🎯 Guess the Secret Code
- Use: do-while + if
- Task: User guesses a 4-digit code (e.g., 5731). Give hints if too low/high.
- Loop until correct guess.
4. 🎰 Simple Slot Machine
- Use: while loop + switch
- Task: Simulate 3 slots (🍒, 🍋, 🔔) using Random.
- switch result: all 3 → "Big Win", 2 same → "Small Win", else → "Try again".
- Continue until user quits.
5. 🔐 Login Attempt System
- Use: do-while + if
- Task: User gets 3 tries to enter correct username/password.
- Success → "Login Successful", fail → "Account Locked".
6. 🏧 ATM Menu System
- Use: while + switch
- Display menu: 1. Check Balance, 2. Deposit, 3. Withdraw, 4. Exit.
- switch controls actions. Balance is updated. //todo
- Loop until Exit is selected.
7. 🎓 Student Grade Analyzer
- Use: while loop + if-else
- Task: Input scores 0–100.
- Print grade: A, B, C, D, F.
- Stop on negative input.
8. 🕒 Parking Fee Calculator
- Use: while + if-else
- Task: Ask for hours parked.
- 1–2 hrs: $5, 3–5 hrs: $10, >5 hrs: $15.
- Repeat for multiple customers.
9. 🛒 Discount Calculator
- Use: while + if
- Ask for item prices.
- If price > $100 → apply 10% discount.
- Loop until "0" is entered. Show total before/after discount.
10. 🎮 Game Menu System
- Use: do-while + switch
- Menu: 1. Start Game, 2. Load Game, 3. Quit.
- Respond with different messages.
- Loop until Quit is selected.