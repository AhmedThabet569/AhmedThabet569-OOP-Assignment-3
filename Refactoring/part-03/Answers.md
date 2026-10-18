# Part 03 — answers

---

## BlockedUsers

- Time complexity before: o(1)
- Time (ms) before:44ms
- What did you change?
- 1- change any list to hashset as hashset 
- Time complexity after:o(1)
- Time (ms) after:0ms

---

## Students

- What was the problem?
 - in getAllStudent :
	- this method return new list of students every call so if you use to repeat 1m it will take time
	- also you break it 
- What did you change?
	- using IEnumberble 
	- so get data on you want to use 
	- using yield 
