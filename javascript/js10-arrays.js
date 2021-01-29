/**
*   Return the second largest number in the array.
*   @param {Number[]} nums - An array of numbers.
*   @return {Number} The second largest number in the array.
**/
function getSecondLargest(nums) {
    
    let sorted = nums.filter((v, i, a) => a.indexOf(v) === i).sort((a, b) => a-b);
    return sorted[sorted.length-2];
}