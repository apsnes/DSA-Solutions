class Solution:
    def canBeTypedWords(self, text: str, brokenLetters: str) -> int:
        words = text.split(' ')
        res = len(words)

        for w in words:
            broken = False
            for c in w:
                if not broken and c in brokenLetters:
                    broken = True
                    res -= 1
                    continue

        return res 
