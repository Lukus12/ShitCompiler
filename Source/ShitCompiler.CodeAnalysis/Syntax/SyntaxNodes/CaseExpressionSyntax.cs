using ShitCompiler.CodeAnalysis.Lexicon;
namespace ShitCompiler.CodeAnalysis.Syntax.SyntaxNodes;

public sealed record CaseExpressionSyntax(
    Lexeme CaseKeyword,
    Lexeme Identifier,
    BlockStatementSyntax Block,
    Lexeme SemicolonToken

) : StatementSyntax(
    SyntaxKind.CaseKeyword
)
{
    public override IEnumerable<ISyntaxNode> GetChildren()
    {
        return [
            CaseKeyword,
            Identifier,
            Block,
            SemicolonToken
         ];
    }
}
