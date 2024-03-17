# Find-the-Pivot-Integer
Challenge at LeetCode.com. Tags: Math.

The solution to this problem is based on the following reasoning:   

If for a given integer 'n', there is a integer 'x', where '1<=x<=n' for which the sum from 1 to 'x' is equal to the sum from 'x' to 'n' then, 
by applying the formula for the sum of all members of arithmetic progression with first member 1 and step of increase 1, we have the following equation:                 
x*(x+1)/2 = n*(n+1)/2 -  x*(x+1)/2 + x    
            
After simplification:        
x*x = n*(n+1)/2                 

Therefore:         
If square root of n*(n+1)/2 is an integer, then there is such an integer value 'x'       
where '1<=x<=n' for which the sum from 1 to 'x' is equal to the sum from 'x' to 'n'      
