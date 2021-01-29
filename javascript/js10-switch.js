function getLetter(s) {
    const A = ['a','e','i','o','u'];
    const B = ['b','c','d','f','g'];
    const C = ['h','j','k','l','m'];
    const D = ['n','p','q','r','s','t','v','w','x','y','z'];
    
    let letter;
    if (A.includes(s[0])) letter = 'A';
    else if (B.includes(s[0])) letter = 'B';
    else if (C.includes(s[0])) letter = 'C';
    else if (D.includes(s[0])) letter = 'D';    
    return letter;
}