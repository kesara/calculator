# Read Me #

Calculator.NET is an easy to use calculator with unique features. Calculator.NET can be used to perform any of the standard operations for which you would normally use a calculator.
Available mathematical operations are,
  * Standard arithmetic operations: Addition, subtraction, multiplication, division
  * Indices operation's: Square, cube, square root, _n_ th power.
  * Factorial
  * Memory Operations

## Limitations ##

### Factorial Calculation ###
  * Factorial calculations are calculated only up to _170_. Values larger than _170_ will return Infinity.
  * If value to be calculate factorial is less than zero, NaN (Not a Number) will be returned.

## Important ##
### Division By Zero ###
Division by zero returns according to The IEEE floating-point standard.
  * _a_ ÷ _0_ is positive infinity when _a_ is positive
  * _a_ ÷ _0_ is negative infinity when _a_ is negative
  * _a_ ÷ _0_ is NaN (not a number) when _a_ = _0_.

### Square Root of Negative Values ###
Square root of negative values will return NaN (Not a Number).

### Infinity ###
Infinity value resulted by calculations can be used in any other calculation.

### NaN ###
NaN (Not a Number) is a value or symbol that is usually produced as the result of an operation on invalid input operand. NaN value resulted by calculations can be in any other calculation, but the result will be always NaN.

### Unicode Support ###
The calculator uses Unicode character set. Text pad files will also saved as Unicode text files.

## See Also ##
  * [Calculator.NET Online Help](OnlineHelp.md)

## Further Reading ##
  * [Division by zero](http://en.wikipedia.org/wiki/Division_by_zero)
  * [The IEEE Standard for Binary Floating-Point Arithmetic (IEEE 754)](http://en.wikipedia.org/wiki/IEEE_floating-point_standard)
  * [Infinity](http://en.wikipedia.org/wiki/Infinity#In_computing)
  * [NaN](http://en.wikipedia.org/wiki/NaN)
  * [Unicode](http://en.wikipedia.org/wiki/Unicode)