# Balanced Brackets

This console application checks whether brackets in an expression are balanced and correctly nested.

## Logic

The program uses `CharacterStack` to store opening brackets while scanning the expression from left to right:

1. Opening brackets (`(`, `{`, `[`) are pushed onto the stack.
2. For each closing bracket (`)`, `}`, `]`):
   - If the stack is empty, there is no matching opening bracket, so the expression is unbalanced.
   - Otherwise, the most recent opening bracket is popped.
   - The popped bracket must match the closing bracket. For example, `]` must match `[`. If it does not, the expression is unbalanced.
3. After the complete expression is scanned, the stack must be empty. Any remaining opening brackets are unmatched.

This is a last-in, first-out (LIFO) process: the most recently opened bracket must be closed first.

## Example

```text
Input:  {[()]}
Output: Brackets are balanced.

Input:  (testy))
Output: Brackets are not balanced.
```

The algorithm runs in `O(n)` time and uses `O(n)` additional space, where `n` is the length of the expression.

## PowerShell warning

When using PowerShell, do not enter an expression such as `(testy))` directly as a command. PowerShell interprets parentheses as part of its own command syntax and may report:

```text
Unexpected token ')' in expression or statement.
```

Start the application first, then enter the expression when the program displays `Enter an expression:`:

```powershell
dotnet run
```

Alternatively, quote the expression when piping it into the program:

```powershell
"(testy))" | dotnet run
```
