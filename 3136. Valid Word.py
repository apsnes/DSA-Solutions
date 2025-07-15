class Solution:
    def isValid(self, word: str) -> bool:
        vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']
        return len(word) >= 3 and word.isalnum() and any(char in vowels for char in word) and (any(char.isalpha() and char not in vowels for char in word))
