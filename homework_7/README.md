## 🧠 **Homework Tasks for Conditional and Null-Coalescing Operators**

---

### 🔸 **Task 1: Age Group Categorizer (Conditional Operator `?:`)**

**Scenario**: You’re helping a clinic categorize patients based on age.

#### Requirements:

* Ask the user to input their age.
* Use the **conditional operator** to determine their group:

  * Age < 13 → "Child"
  * Age 13–17 → "Teenager"
  * Age 18–64 → "Adult"
  * Age 65+ → "Senior"

📌 **Output example**:

```text
Enter your age: 45
You are an: Adult
```

> 🔁 Use nested conditional operators for multiple conditions.

---

### 🔸 **Task 2: Optional Discount Code (Null-Coalescing `??`)**

**Scenario**: An online store allows users to enter an optional discount code.

#### Requirements:

* Ask the user to input a discount code (or press Enter to skip).
* Use `??` to replace a `null` or empty string with `"NO CODE ENTERED"`.
* Display the discount code used.

📌 **Output example**:

```text
Enter discount code: [User presses Enter]
Discount applied: NO CODE ENTERED
```

> 💡 Hint: Use `string.IsNullOrWhiteSpace()` + `??` for robustness.

---

### 🔸 **Task 3: Product Description Fallback (`?.` and `??`)**

**Scenario**: A shopping cart may have some missing product descriptions.

#### Requirements:

* Create a `Product` class with:

  * `Name` (string)
  * `Description` (string?, nullable)
* Create 2–3 product instances, some with `Description = null`.
* Use the **null-conditional operator** (`?.`) and **null-coalescing operator** (`??`) to display:

  * `product.Description ?? "No description available"`

📌 **Output example**:

```text
Product: Headphones
Description: High-quality sound

Product: Cable
Description: No description available
```

---

### 🔸 **Task 4: Fallback Username (Chained `??`)**

**Scenario**: An app generates display names with multiple fallback options.

#### Requirements:

* Ask the user for: `preferredName`, `nickname`, and `username`.
* Use **chained `??` operators** to display the first available:

  * `preferredName ?? nickname ?? username ?? "Guest"`

📌 **Output example**:

```text
Preferred name: [empty]
Nickname: [empty]
Username: john_doe
Hello, john_doe!
```

---

### 🔸 **Task 5: Safe Object Access with Null-Conditional Operator (`?.`)**

**Scenario**: You’re accessing a property from a possibly null object.

#### Requirements:

* Create a `User` class with a nullable `Profile` property.
* `Profile` contains a string `Bio`.
* Use `?.` to safely access `user.Profile?.Bio`.
* Use `??` to provide a fallback if `Bio` is null.

📌 **Output example**:

```text
User bio: No bio set.
```

> 🧠 **Encourages understanding null-safety in object navigation.**

---


