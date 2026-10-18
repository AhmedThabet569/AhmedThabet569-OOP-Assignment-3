# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
-  problem is calaculte shipping depend on shipping company so if i want to add new shipping company 
	- i will edit on class and this violte ocp 
- What did you change?
- i will create abstract class that have magic number of company shipping tax and method calculte to calc 
- shipping tax 
- then built class for each company implment abstract class
- 

---

## OrderProcessor

- What was the problem?
- problem in call calss of one type in base class what if i want to add mongo db or mysql 
- what if changed smptemail to other mail server 
- What did you change?
- i create 2 interface have methods  of every type db or mail and included theme in base class
- once user want to add new mail server or db create it in program.cs and pass theme to method in
- base class

---

## Notifications

- What was the problem?
- What did you change?

---

## Proof

- New carrier file(s):
- New notification channel file(s):
- Existing classes left unchanged? (yes/no):
