class Solution:
    def findClosest(self, x: int, y: int, z: int) -> int:
        p1dist = abs(z - x)
        p2dist = abs(z - y)
        return 1 if p1dist < p2dist else 2 if p2dist < p1dist else 0
