using ShitCompiler.CodeAnalysis.Lexicon;

namespace ShitCompiler.CodeAnalysis.Syntax.SyntaxNodes;

public sealed record VariableDeclarationSyntax(
 //   Lexeme Keyword,
    Lexeme Identifier,
    TypeClauseSyntax TypeClause,
  //  Lexeme EqualsToken,
  //  ExpressionSyntax Initializer,
    Lexeme SemicolonToken
) : StatementSyntax(
    SyntaxKind.VariableDeclaration
)
{

    public override IEnumerable<ISyntaxNode> GetChildren()
    {
        return new List<ISyntaxNode?>(){
        //    Keyword,
            Identifier,
            TypeClause,
        //    EqualsToken,
        //    Initializer,
            SemicolonToken
        }.Where(n => n is not null)!;
    }

}