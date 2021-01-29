function getGrade(score) {
   if (isInRange(score, -1, 6)) return "F";
   if (isInRange(score, 5, 11)) return "E";
   if (isInRange(score, 10, 16)) return "D";
   if (isInRange(score, 15, 21)) return "C";
   if (isInRange(score, 20, 26)) return "B";
   if (isInRange(score, 25, 31)) return "A";
}

function isInRange(value, from, to) {
    return value > from && value < to;
}