class Solution:
    def nextGreatestLetter(self, letters: List[str], target: str) -> str:
        res = letters[0]

        for letter in reversed(letters):
            if letter <= target:
                return res
            
            if letter > target:
                res = letter

        return res
