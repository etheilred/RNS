//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ASM.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IASMListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class ASMBaseListener : IASMListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ASMParser.asm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsm([NotNull] ASMParser.AsmContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ASMParser.asm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsm([NotNull] ASMParser.AsmContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ASMParser.base"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBase([NotNull] ASMParser.BaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ASMParser.base"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBase([NotNull] ASMParser.BaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ASMParser.commands"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommands([NotNull] ASMParser.CommandsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ASMParser.commands"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommands([NotNull] ASMParser.CommandsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ASMParser.label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabel([NotNull] ASMParser.LabelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ASMParser.label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabel([NotNull] ASMParser.LabelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ASMParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommand([NotNull] ASMParser.CommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ASMParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommand([NotNull] ASMParser.CommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ASMParser.arithmetic"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmetic([NotNull] ASMParser.ArithmeticContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ASMParser.arithmetic"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmetic([NotNull] ASMParser.ArithmeticContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ASMParser.control_flow"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterControl_flow([NotNull] ASMParser.Control_flowContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ASMParser.control_flow"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitControl_flow([NotNull] ASMParser.Control_flowContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ASMParser.tdc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTdc([NotNull] ASMParser.TdcContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ASMParser.tdc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTdc([NotNull] ASMParser.TdcContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="ASMParser.num_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNum_list([NotNull] ASMParser.Num_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ASMParser.num_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNum_list([NotNull] ASMParser.Num_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>pushNum</c>
	/// labeled alternative in <see cref="ASMParser.stack"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPushNum([NotNull] ASMParser.PushNumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>pushNum</c>
	/// labeled alternative in <see cref="ASMParser.stack"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPushNum([NotNull] ASMParser.PushNumContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>popReg</c>
	/// labeled alternative in <see cref="ASMParser.stack"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPopReg([NotNull] ASMParser.PopRegContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>popReg</c>
	/// labeled alternative in <see cref="ASMParser.stack"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPopReg([NotNull] ASMParser.PopRegContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>pushR</c>
	/// labeled alternative in <see cref="ASMParser.stack"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPushR([NotNull] ASMParser.PushRContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>pushR</c>
	/// labeled alternative in <see cref="ASMParser.stack"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPushR([NotNull] ASMParser.PushRContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>dup</c>
	/// labeled alternative in <see cref="ASMParser.stack"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDup([NotNull] ASMParser.DupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>dup</c>
	/// labeled alternative in <see cref="ASMParser.stack"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDup([NotNull] ASMParser.DupContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
