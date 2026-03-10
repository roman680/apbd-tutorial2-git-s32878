# apbd-tutorial2-git-s32878

---

### 1. When does Git perform a fast-forward and when is a merge commit created?

The merge was not 'fast-forward' because the master branch had a new commit that was not present in feature-max branch.
So fast forward merge will work if a master branch will not have new commits since the feature-max branch was created. 

### 2. What is the practical difference between merge and rebase?
For example, we have branch A and two additional branches, B and C. 
After a merge, all branches remain, and a new commit D is created that 
combines the changes from B and C. After a rebase, the commits from branch C 
are applied on top of branch B, creating a linear history, so branch C does 
not appear separately in the history, but its changes are included in commit D.
### 3. How was the conflict resolved in your repository?
The conflict occured due to different changes on the same block of code in different branches.
So while resolving the conflict I choosed the correct one with the deleting of the function.