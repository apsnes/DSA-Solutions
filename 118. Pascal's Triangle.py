class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        res = [ []*numRows for i in range(numRows)]

        if numRows == 0:
            return res

        res[0] = [1]

        for i in range(1, numRows):
            res[i].append(1)

            for j in range(1, i):
                res[i].append(res[i - 1][j - 1] + res[i - 1][j])

            res[i].append(1)
            
        return res
