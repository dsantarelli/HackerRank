/*
 * Determine the original side lengths and return an array:
 * - The first element is the length of the shorter side
 * - The second element is the length of the longer side
 * 
 * Parameter(s):
 * literals: The tagged template literal's array of strings.
 * expressions: The tagged template literal's array of expression values (i.e., [area, perimeter]).
 */
function sides(literals, ...expressions) {
    const a = expressions[0];
    const p = expressions[1];
    const d = Math.sqrt(p*p - 16*a);
    return [(p + d) / 4, (p - d) / 4].sort((a,b) => a-b);    
}

