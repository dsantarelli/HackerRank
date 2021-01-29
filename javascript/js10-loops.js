/*
 * Complete the vowelsAndConsonants function.
 * Print your output using 'console.log()'.
 */
function vowelsAndConsonants(s) {
    let vowels = ['a','e','i','o','u'];
    let str = Array.from(s);
    str.filter(x => vowels.includes(x) === true).forEach(x => console.log(x));
    str.filter(x => vowels.includes(x) === false).forEach(x => console.log(x));
}