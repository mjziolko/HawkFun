// Signature file for parser generated by fsyacc
module Parser
type token = 
  | EOF
  | SEMI
  | ARROW
  | DCOLON
  | COLON
  | LBRACK
  | RBRACK
  | LPAR
  | RPAR
  | EQ
  | NE
  | LT
  | LTE
  | PLUS
  | MINUS
  | TIMES
  | DIV
  | TL
  | LOCAL
  | NOT
  | NULL
  | PRINT
  | REC
  | THEN
  | TRUE
  | UNIT
  | VAR
  | BOOL
  | ELSE
  | END
  | FALSE
  | FN
  | FUN
  | HD
  | IF
  | IN
  | INT
  | ISE
  | LIST
  | NAT of (int)
  | NAME of (string)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_SEMI
    | TOKEN_ARROW
    | TOKEN_DCOLON
    | TOKEN_COLON
    | TOKEN_LBRACK
    | TOKEN_RBRACK
    | TOKEN_LPAR
    | TOKEN_RPAR
    | TOKEN_EQ
    | TOKEN_NE
    | TOKEN_LT
    | TOKEN_LTE
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_TIMES
    | TOKEN_DIV
    | TOKEN_TL
    | TOKEN_LOCAL
    | TOKEN_NOT
    | TOKEN_NULL
    | TOKEN_PRINT
    | TOKEN_REC
    | TOKEN_THEN
    | TOKEN_TRUE
    | TOKEN_UNIT
    | TOKEN_VAR
    | TOKEN_BOOL
    | TOKEN_ELSE
    | TOKEN_END
    | TOKEN_FALSE
    | TOKEN_FN
    | TOKEN_FUN
    | TOKEN_HD
    | TOKEN_IF
    | TOKEN_IN
    | TOKEN_INT
    | TOKEN_ISE
    | TOKEN_LIST
    | TOKEN_NAT
    | TOKEN_NAME
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startMain
    | NONTERM_Main
    | NONTERM_Expr
    | NONTERM_AtExpr
    | NONTERM_Const
    | NONTERM_TName
    | NONTERM_Bindings
    | NONTERM_Binding
    | NONTERM_AppExpr
    | NONTERM_Type
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Main : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (Absyn.expr) 