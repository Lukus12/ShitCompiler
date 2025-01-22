using ShitCompiler.CodeAnalysis.Lexicon;
namespace ShitCompiler.CodeAnalysis.Syntax.SyntaxNodes;

public sealed record CaseExpressionSyntax(
    Lexeme CaseKeyword,
    Lexeme Indenteficator,
    Lexeme OfKeyword,
    Lexeme EndKeyword
) : StatementSyntax(
    SyntaxKind.CaseKeyword
)
{
    public override IEnumerable<ISyntaxNode> GetChildren()
    {
        return [
            CaseKeyword,
            Indenteficator,
            OfKeyword,
            EndKeyword
         ];
    }
}
