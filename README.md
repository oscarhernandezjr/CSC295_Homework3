CSC295_Homework3

This week's homework assignment focused on sorting an array of students by their gpa with the use of three different sorting algorithms. They are bubble sort, selection sort, and insertion sort, with all of them having the same goal in placing their respective gpa from lowest to highest. In the following, I will explain each of their use as well as the output that it would equate to.

First, we input five students along with their gpa, Melissa, Rich, Adam, Madeline and Kevin, with an the intention to of selecting one of the three algorithm.

As mentioned, we having the intention in comparing all of the students along with placing them from lowest gpa to highest. Bubble sort, however, the steps repeatedly swapped all of the elements until they were sorted. First, we compared Melissa who had a gpa of 4.0 with Rich who held a 3.0. Since Melissa's gpa was higher, they switched positions. The cycle were continuously repeated. The final output gave us a sorted array of Kevin: 2.4, Rich: 3.0, Adam: 3.8, Madeline: 3.9, and Melissa: 4.0

In selection sort, we start by focusing on the lowest gpa, hence taking Kevin. We swap Kevin with the first element in the array, Melissa. We continue by finding the next lowest gpa in the unsorted array, it being Rich. We do this until all elements have taken in consideration all elements the in the unsorted list and placed them in the sorted array. 

Lastly, insertion sort builds the sorted array one element at a time. By taking one element from the unsorted array and placing it in the sorted array, it is placed in the right position. In the first cycle, we take a look Adam and compare it with Melissa. Since Melissa's gpa is higher, we switch it with Rich's. In the second pass, we do the same by comparing Melissa with Adam. Again, since it is higher, we move Melissa to the right. We repeat this cycle with each element. In the third cycle, we look at Madeline and compare with Melissa once more. Again, Melissa is shifted to the right. 

An issue that I faced was maintaining the readability of the code. After each change, I misconstrued keeping the code in the correct format as well as missing potential ";". Moreover, I struggled with testing the program as I continued my project from a MAC to Windows, and much of the code did not translate well. However, I did enjoy this assignment as I was able to find analogies in the real world that could translate and did not consider.  
