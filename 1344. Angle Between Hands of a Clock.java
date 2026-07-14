// Minute hand moves 360/60 = 6 degrees per minute.
// Hour hand moves 360/12 = 30 degrees per hour.
// Hour hand will also move 360/12 = 30. 30/5 = 6 degrees every 12 minutes. 6 / 12 = 0.5 degrees per minute.

class Solution {
    public double angleClock(int hour, int minutes) {
        var hourMoved = minutes * 0.5;
        var minuteAngle = 6 * minutes;
        var hourAngle = 30 * (hour % 12) + hourMoved;
        var diff = Math.abs(minuteAngle - hourAngle);
        return Math.min(diff, 360 - diff);
    }
}
