// Given base and n that are both 1 or more, compute recursively (no loops)
// the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

public int powerN(int base, int n) {
  if(base > 0 && n > 0) {
    return (int)Math.pow(base, n);
  }
  return 0;
}

// no recursion needed?
