# Training for Junior Microsoft CRM Developers with Employment 
## TEST TASK
You need to implement C# method according to the following description: <br>

To the method input you receive a: <br>
1.	start date, <br>
2.	duration in days (whole number) and <br>
3.	weekends (array of objects with the fields "start date" and "end date") <br>

If "start date" is the same with the "end date", it means the weekend happens  <br> 
only on that day. If "start date" isn't same with the "end date", it means that the <br>  
whole period is a weekend.  <br>

Example.  <br>
23/04/2017 - 25/04/2017, two weekends (Saturday and Sunday) and 25th is a holiday, <br> 
 3 weekends in total.  <br>

The array is sorted by the start date, periods do not intersect.  <br>
At the end the function should return the date, which is counted as a start date + duration,   <br>
without weekends. Start date is the first day of the period.  <br>

Investigate and take into account all possible intersections of startdate, duration and   <br>
weekend  <br>

Example 1.<br>
Start date: 21/04/2017 Duration: 5 days<br>
Weekends: 23/04/2017 - 25/04/2017<br>
At the exit there should be: End date 28/04/2017<br>

Explanation<br>
1st day = 21.04.2017<br>
2nd day = 22.04.2017<br>
23.04.2017 excluded as weekend 24.04.2017 excluded as weekend 25.04.2017 excluded as weekend 3rd day = 26.04.2017<br>
4th day = 27.04.2017<br>
5th day = 28.04.2017<br>

Example 2.<br>
Start date: 21/04/2017 Duration: 5 days<br>
Weekends 1: 23/04/2017 - 25/04/2017<br>
Weekends 2: 29/04/2017 - 29/04/2017<br>
At the exit there should be: End date 28/04/2017<br>

Explanation<br>
1st day = 21.04.2017<br>
2nd day = 22.04.2017<br>
23.04.2017 excluded as weekend 24.04.2017 excluded as weekend 25.04.2017 excluded as weekend 3rd day = 26.04.2017<br>
4th day = 27.04.2017<br>
5th day = 28.04.2017<br>
Second weekend is not taken to account because duration ended before weekend<br>

Implement method Calculate in class WorkDayCalculator in project CSharpTest delivered with test<br>
Execute test methods to ensure you done logic correctly<br>
Add other tests you think are meningfull to verify all possible scenarious for function call<br>

