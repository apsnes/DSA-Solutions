class Solution:
    def areaOfMaxDiagonal(self, dimensions: List[List[int]]) -> int:
        res = 0
        longest_dia = 0
        n = len(dimensions)
        for i in range(n):
            current_dia = sqrt((dimensions[i][0] * dimensions[i][0]) + (dimensions[i][1] * dimensions[i][1]))
            current_area = dimensions[i][0] * dimensions[i][1]
            if current_dia > longest_dia:
                longest_dia = current_dia
                res = current_area
            elif current_dia == longest_dia:
                res = max(res, current_area)
        return res
