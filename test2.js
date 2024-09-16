function validSolution(t)
{
    for(i=0; i<9; i++)
    {
        var found = []
        for(j=0; j<9; j++)
        {
            for(k=0; k<found.length; k++)
            {
                if(t[i][j] == 0)
                {
                    return false
                }
                if(t[i][j] == found[k])
                {
                    return false
                }
            }
            found.push(t[i][j])
        }
    }
    for(j=0; j<9; j++)
    {
        var found = []
        for(i=0; i<9; i++)
        {
            for(k=0; k<found.length; k++)
            {
                if(t[i][j] == found[k])
                {
                    return false
                }
            }
            found.push(t[i][j])
        }
    }
    for(n=0; n<3; n++)
    {
        for(m=0; m<3; m++)
        {
            var found = []
            for(i=3*n; i<3*(n+1); i++)
            {
                for(j=3*m; j<3*(m+1); j++)
                {
                    for(k=0; k<found.length; k++)
                    {
                        if(t[i][j] == found[k])
                        {
                            return false
                        }
                    }
                    found.push(t[i][j])
                }
            }
        }
    }
    return true
}

var result = validSolution([
  [5, 3, 4, 6, 7, 8, 9, 1, 2],
  [6, 7, 2, 1, 9, 5, 3, 4, 8],
  [1, 9, 8, 3, 4, 2, 5, 6, 7],
  [8, 5, 9, 7, 6, 1, 4, 2, 3],
  [4, 2, 6, 8, 5, 3, 7, 9, 1],
  [7, 1, 3, 9, 2, 4, 8, 5, 6],
  [9, 6, 1, 5, 3, 7, 2, 8, 4],
  [2, 8, 7, 4, 1, 9, 6, 3, 5],
  [3, 4, 5, 2, 8, 6, 1, 7, 9]
])
print(result)