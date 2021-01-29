function getMaxLessThanK(n, k) {
    let largest = 0;
    let current = 0;
    for (let i = 1; i < n; i++) {
        for (let x = i + 1; x <= n; x++) {
            current = i & x;
            if (current < k && current < n && current > largest) {
                largest = current;
            }
        }
    }
    return largest;
}

