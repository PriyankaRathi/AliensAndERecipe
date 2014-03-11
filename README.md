AliensAndERecipe
================

This is a CodeChef practice program. This check how many recipes aliens can download in particular time interval
The aliens living in outer space are very advanced in technology,
intelligence and everything, except one, and that is Cooking.
Each year they spend millions of dollars in research, to crack famous recipes prepared by humans.
Recently they came to know about Khana-Academy,
a non-profit organization streaming free cooking lesson videos on earth.
There are N recipes,
numbered 1 to N, and the video of the ith recipe is live in the time interval [Si, Ei].
An alien can visit earth but can not survive for more than just a small moment (earth is so advanced in pollution).
An alien visits the earth at an integer time t and instantly downloads the complete video of all the lessons
that are live at that moment of time t and leaves earth immediately.
You are given the visiting times of a small group of K aliens.
Find the number of different recipes aliens can learn by watching the downloaded videos.
Not just one group of aliens, there are Q such groups,
so you have to find the answer for each of these Q groups.
Input

The first line has an integer N.
Each of the following N lines has two integers Si Ei.
The next line has an integer Q, the number of groups.
Each of the following Q lines has information of a group of aliens.
The first integer is K, the number of aliens in that group, followed by K integers in the same line,
the integer visiting times t of the aliens.

Output

For each of the Q groups, output the number of different recipes that group of aliens can learn by watching the downloaded videos.
Example

Input:
4
1 4
3 10
2 6
5 8
3
1 5
2 2 6
3 1 10 9

Output:
3
4
2
Explanation:
Given videos of 4 recipes in the following closed intervals.
1. [ 1 , 4 ]
2. [ 3 , 10 ]
3. [ 2 , 6 ]
4. [ 5 , 8 ]
In the first query, only one alien arrives at t = 5 and can download 3 recipes 2, 3, 4.
In the second query, two aliens arrive at t = 2 and 6. They can learn all the 4 recipes.
In the third query, three aliens arrive at t = 1, 10 and 9. They can learn only two recipes, 1 and 2.
