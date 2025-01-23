using ShitCompiler.CodeAnalysis.Lexicon;
using System.Linq;
using System.Text;

namespace ShitCompiler.CodeAnalysis.Syntax.SyntaxNodes;

public sealed record FunctionDeclarationSyntax(
    Lexeme Var,
    SeparatedSyntaxList<ParameterSyntax> Parameters,
    BlockStatementSyntax Block,
    Lexeme DotToken
) : MemberSyntax(SyntaxKind.FunctionDeclaration)
{

    public override IEnumerable<SyntaxNode> GetChildren()
    {
        return new List<SyntaxNode>(){
                Var,
            }.Concat(
                Parameters.GetWithSeparators()
            ).Concat([
                Block,
                DotToken
                ]
            );
    }

};