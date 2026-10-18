# Collection  Questions

1-what is IReadOnlyDictionary<TKey,TValue> :
  - interface provide read-only view of Dictionary
  - not for sorted elements
  - Implementation: Implemented by classes like Dictionary<TKey, TValue> and 

 2- what is SortedDictionary<TKey, TValue>:
   - concerte class 
    - sorted elements  automatic 
    - allowed for read add edit remove 
================================================================
3- how is IReadOnlyDictionary different from Dictionary
   as i said IReadOnlyDictionary => is for read only  , for read data from Dictionary and pass data out class
    and Dictionary => i s for all opertions such as read write edit delete,  for collect data
================================================================
4- why would a public method return one instead of a Dictionary: 
        as if i return public method and Dictionary if caller call this method 
        it give him access to edit or remove Dictionary
        but if i use IReadOnlyDictionary caller can't edit on Dictionary
================================================================

5-speed : IReadOnlyDictionary => speed faster than Dictionary =>O(log n)
============================================================================================

task 2 => 
S1 — Find a student by national ID — thousands of times a day.
   => use Dictionary to find national id  as you 

S2 - Keep the tags of a course. The same tag must never be stored twice.
  => use Hashset as it remove duplicate 

S3 — Keep a student's grades in the order they were entered. The same grade can appear more than once.
 =>  use  SortedDictionary as it sorted elements in order and

S4 — A public method returns the course price list. Callers can read prices but must not add or change any.
 => IReadOnlyDictionary is it for readonly elements 

S5 — A timetable keyed by session start time. Sessions are added at any moment, and it must always print in
time order.
 => 
S6 - A method returns results that the caller only loops over once — and may stop early
  => IEnumerable that insted of for loop for result and started to exuted later 

 


 

