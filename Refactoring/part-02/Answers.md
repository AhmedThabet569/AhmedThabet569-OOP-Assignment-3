# Part 02 — answers

---

## Reports

- What was the problem?
  - repeat code of 3 method and data for all three class
  - 3 method make same for all classes 
  - if you change behvioor of one you will repeat this changes for all
  - What did you change?
  -  make one abstract class have 3 implmention code for those 
  - and make 3 classes inherit from it 
- Why did you choose that approach?
  - because there are  methoods have same behavior except format method 
  - so what i make theme in abstract class and leave implmention for last method
  - format to every class 

---

## Enrollment

- What was the problem?
  - not problem but it multi services so 
  - if i want to run all theme i will create instance of every class 
- What did you change?
  - i create one class to proccess all services in one class without create instance of 
  - every class
- Why did you choose that approach?
  - facade design pattren so it help me to collect all services 
  - and render them in single code lines
  - so if i forget any services in old way it will broke application bussiness 
  - but in this solution i  create one class collect all of theme
  
