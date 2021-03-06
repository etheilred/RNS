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

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class ASMParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NUMBER=7, ADD=8, SUB=9, 
		MUL=10, MOD=11, DIV=12, CMP=13, TDC=14, PUSH=15, PUSHR=16, POP=17, JMP=18, 
		JNE=19, JEQ=20, JLT=21, JGT=22, JLE=23, JGE=24, DUP=25, NEG=26, LABEL=27, 
		WS=28, COMMENT=29;
	public const int
		RULE_asm = 0, RULE_base = 1, RULE_commands = 2, RULE_label = 3, RULE_command = 4, 
		RULE_arithmetic = 5, RULE_control_flow = 6, RULE_tdc = 7, RULE_num_list = 8, 
		RULE_stack = 9;
	public static readonly string[] ruleNames = {
		"asm", "base", "commands", "label", "command", "arithmetic", "control_flow", 
		"tdc", "num_list", "stack"
	};

	private static readonly string[] _LiteralNames = {
		null, "'\r\n'", "':'", "'{'", "'}'", "'A'", "'B'", null, "'ADD'", "'SUB'", 
		"'MUL'", "'MOD'", "'DIV'", "'CMP'", "'TDC'", "'PUSH'", "'PUSHR'", "'POP'", 
		"'JMP'", "'JNE'", "'JEQ'", "'JLT'", "'JGT'", "'JLE'", "'JGE'", "'DUP'", 
		"'NEG'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "NUMBER", "ADD", "SUB", "MUL", 
		"MOD", "DIV", "CMP", "TDC", "PUSH", "PUSHR", "POP", "JMP", "JNE", "JEQ", 
		"JLT", "JGT", "JLE", "JGE", "DUP", "NEG", "LABEL", "WS", "COMMENT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ASM.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ASMParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public ASMParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public ASMParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class AsmContext : ParserRuleContext {
		public BaseContext @base() {
			return GetRuleContext<BaseContext>(0);
		}
		public CommandsContext commands() {
			return GetRuleContext<CommandsContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(ASMParser.Eof, 0); }
		public AsmContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_asm; } }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterAsm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitAsm(this);
		}
	}

	[RuleVersion(0)]
	public AsmContext asm() {
		AsmContext _localctx = new AsmContext(Context, State);
		EnterRule(_localctx, 0, RULE_asm);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 20; @base();
			State = 21; commands();
			State = 22; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BaseContext : ParserRuleContext {
		public Num_listContext num_list() {
			return GetRuleContext<Num_listContext>(0);
		}
		public BaseContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_base; } }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterBase(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitBase(this);
		}
	}

	[RuleVersion(0)]
	public BaseContext @base() {
		BaseContext _localctx = new BaseContext(Context, State);
		EnterRule(_localctx, 2, RULE_base);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 24; num_list();
			State = 25; Match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CommandsContext : ParserRuleContext {
		public LabelContext[] label() {
			return GetRuleContexts<LabelContext>();
		}
		public LabelContext label(int i) {
			return GetRuleContext<LabelContext>(i);
		}
		public CommandContext[] command() {
			return GetRuleContexts<CommandContext>();
		}
		public CommandContext command(int i) {
			return GetRuleContext<CommandContext>(i);
		}
		public CommandsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_commands; } }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterCommands(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitCommands(this);
		}
	}

	[RuleVersion(0)]
	public CommandsContext commands() {
		CommandsContext _localctx = new CommandsContext(Context, State);
		EnterRule(_localctx, 4, RULE_commands);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << SUB) | (1L << MUL) | (1L << MOD) | (1L << DIV) | (1L << CMP) | (1L << TDC) | (1L << PUSH) | (1L << PUSHR) | (1L << POP) | (1L << JMP) | (1L << JNE) | (1L << JEQ) | (1L << JLT) | (1L << JGT) | (1L << JLE) | (1L << JGE) | (1L << DUP) | (1L << NEG) | (1L << LABEL))) != 0)) {
				{
				{
				State = 29;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case LABEL:
					{
					State = 27; label();
					}
					break;
				case ADD:
				case SUB:
				case MUL:
				case MOD:
				case DIV:
				case CMP:
				case TDC:
				case PUSH:
				case PUSHR:
				case POP:
				case JMP:
				case JNE:
				case JEQ:
				case JLT:
				case JGT:
				case JLE:
				case JGE:
				case DUP:
				case NEG:
					{
					State = 28; command();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 31; Match(T__0);
				}
				}
				State = 37;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LabelContext : ParserRuleContext {
		public ITerminalNode LABEL() { return GetToken(ASMParser.LABEL, 0); }
		public LabelContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_label; } }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterLabel(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitLabel(this);
		}
	}

	[RuleVersion(0)]
	public LabelContext label() {
		LabelContext _localctx = new LabelContext(Context, State);
		EnterRule(_localctx, 6, RULE_label);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 38; Match(LABEL);
			State = 39; Match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CommandContext : ParserRuleContext {
		public ArithmeticContext arithmetic() {
			return GetRuleContext<ArithmeticContext>(0);
		}
		public Control_flowContext control_flow() {
			return GetRuleContext<Control_flowContext>(0);
		}
		public StackContext stack() {
			return GetRuleContext<StackContext>(0);
		}
		public TdcContext tdc() {
			return GetRuleContext<TdcContext>(0);
		}
		public CommandContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_command; } }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterCommand(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitCommand(this);
		}
	}

	[RuleVersion(0)]
	public CommandContext command() {
		CommandContext _localctx = new CommandContext(Context, State);
		EnterRule(_localctx, 8, RULE_command);
		try {
			State = 45;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ADD:
			case SUB:
			case MUL:
			case MOD:
			case DIV:
			case CMP:
			case NEG:
				EnterOuterAlt(_localctx, 1);
				{
				State = 41; arithmetic();
				}
				break;
			case JMP:
			case JNE:
			case JEQ:
			case JLT:
			case JGT:
			case JLE:
			case JGE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 42; control_flow();
				}
				break;
			case PUSH:
			case PUSHR:
			case POP:
			case DUP:
				EnterOuterAlt(_localctx, 3);
				{
				State = 43; stack();
				}
				break;
			case TDC:
				EnterOuterAlt(_localctx, 4);
				{
				State = 44; tdc();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArithmeticContext : ParserRuleContext {
		public IToken cmd;
		public ITerminalNode ADD() { return GetToken(ASMParser.ADD, 0); }
		public ITerminalNode SUB() { return GetToken(ASMParser.SUB, 0); }
		public ITerminalNode MUL() { return GetToken(ASMParser.MUL, 0); }
		public ITerminalNode DIV() { return GetToken(ASMParser.DIV, 0); }
		public ITerminalNode MOD() { return GetToken(ASMParser.MOD, 0); }
		public ITerminalNode CMP() { return GetToken(ASMParser.CMP, 0); }
		public ITerminalNode NEG() { return GetToken(ASMParser.NEG, 0); }
		public ArithmeticContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arithmetic; } }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterArithmetic(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitArithmetic(this);
		}
	}

	[RuleVersion(0)]
	public ArithmeticContext arithmetic() {
		ArithmeticContext _localctx = new ArithmeticContext(Context, State);
		EnterRule(_localctx, 10, RULE_arithmetic);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 47;
			_localctx.cmd = TokenStream.LT(1);
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << ADD) | (1L << SUB) | (1L << MUL) | (1L << MOD) | (1L << DIV) | (1L << CMP) | (1L << NEG))) != 0)) ) {
				_localctx.cmd = ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Control_flowContext : ParserRuleContext {
		public IToken cmd;
		public ITerminalNode LABEL() { return GetToken(ASMParser.LABEL, 0); }
		public ITerminalNode JMP() { return GetToken(ASMParser.JMP, 0); }
		public ITerminalNode JEQ() { return GetToken(ASMParser.JEQ, 0); }
		public ITerminalNode JNE() { return GetToken(ASMParser.JNE, 0); }
		public ITerminalNode JLT() { return GetToken(ASMParser.JLT, 0); }
		public ITerminalNode JGT() { return GetToken(ASMParser.JGT, 0); }
		public ITerminalNode JLE() { return GetToken(ASMParser.JLE, 0); }
		public ITerminalNode JGE() { return GetToken(ASMParser.JGE, 0); }
		public Control_flowContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_control_flow; } }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterControl_flow(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitControl_flow(this);
		}
	}

	[RuleVersion(0)]
	public Control_flowContext control_flow() {
		Control_flowContext _localctx = new Control_flowContext(Context, State);
		EnterRule(_localctx, 12, RULE_control_flow);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 49;
			_localctx.cmd = TokenStream.LT(1);
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << JMP) | (1L << JNE) | (1L << JEQ) | (1L << JLT) | (1L << JGT) | (1L << JLE) | (1L << JGE))) != 0)) ) {
				_localctx.cmd = ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 50; Match(LABEL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TdcContext : ParserRuleContext {
		public ITerminalNode TDC() { return GetToken(ASMParser.TDC, 0); }
		public TdcContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tdc; } }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterTdc(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitTdc(this);
		}
	}

	[RuleVersion(0)]
	public TdcContext tdc() {
		TdcContext _localctx = new TdcContext(Context, State);
		EnterRule(_localctx, 14, RULE_tdc);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 52; Match(TDC);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Num_listContext : ParserRuleContext {
		public ITerminalNode[] NUMBER() { return GetTokens(ASMParser.NUMBER); }
		public ITerminalNode NUMBER(int i) {
			return GetToken(ASMParser.NUMBER, i);
		}
		public Num_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_num_list; } }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterNum_list(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitNum_list(this);
		}
	}

	[RuleVersion(0)]
	public Num_listContext num_list() {
		Num_listContext _localctx = new Num_listContext(Context, State);
		EnterRule(_localctx, 16, RULE_num_list);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 54; Match(T__2);
			State = 56;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 55; Match(NUMBER);
				}
				}
				State = 58;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==NUMBER );
			State = 60; Match(T__3);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StackContext : ParserRuleContext {
		public StackContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stack; } }
	 
		public StackContext() { }
		public virtual void CopyFrom(StackContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class PushNumContext : StackContext {
		public ITerminalNode PUSH() { return GetToken(ASMParser.PUSH, 0); }
		public ITerminalNode NUMBER() { return GetToken(ASMParser.NUMBER, 0); }
		public Num_listContext num_list() {
			return GetRuleContext<Num_listContext>(0);
		}
		public PushNumContext(StackContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterPushNum(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitPushNum(this);
		}
	}
	public partial class PushRContext : StackContext {
		public ITerminalNode PUSHR() { return GetToken(ASMParser.PUSHR, 0); }
		public PushRContext(StackContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterPushR(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitPushR(this);
		}
	}
	public partial class PopRegContext : StackContext {
		public IToken reg;
		public ITerminalNode POP() { return GetToken(ASMParser.POP, 0); }
		public PopRegContext(StackContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterPopReg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitPopReg(this);
		}
	}
	public partial class DupContext : StackContext {
		public ITerminalNode DUP() { return GetToken(ASMParser.DUP, 0); }
		public DupContext(StackContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.EnterDup(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IASMListener typedListener = listener as IASMListener;
			if (typedListener != null) typedListener.ExitDup(this);
		}
	}

	[RuleVersion(0)]
	public StackContext stack() {
		StackContext _localctx = new StackContext(Context, State);
		EnterRule(_localctx, 18, RULE_stack);
		int _la;
		try {
			State = 71;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case PUSH:
				_localctx = new PushNumContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 62; Match(PUSH);
				State = 65;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case NUMBER:
					{
					State = 63; Match(NUMBER);
					}
					break;
				case T__2:
					{
					State = 64; num_list();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				break;
			case POP:
				_localctx = new PopRegContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 67; Match(POP);
				State = 68;
				((PopRegContext)_localctx).reg = TokenStream.LT(1);
				_la = TokenStream.LA(1);
				if ( !(_la==T__4 || _la==T__5) ) {
					((PopRegContext)_localctx).reg = ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				}
				break;
			case PUSHR:
				_localctx = new PushRContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 69; Match(PUSHR);
				}
				break;
			case DUP:
				_localctx = new DupContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 70; Match(DUP);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x1F', 'L', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', 
		' ', '\n', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '$', '\n', 
		'\x4', '\f', '\x4', '\xE', '\x4', '\'', '\v', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x5', '\x6', '\x30', '\n', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', 
		'\x3', '\n', '\x6', '\n', ';', '\n', '\n', '\r', '\n', '\xE', '\n', '<', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x5', 
		'\v', '\x44', '\n', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x5', '\v', 'J', '\n', '\v', '\x3', '\v', '\x2', '\x2', '\f', '\x2', 
		'\x4', '\x6', '\b', '\n', '\f', '\xE', '\x10', '\x12', '\x14', '\x2', 
		'\x5', '\x4', '\x2', '\n', '\xF', '\x1C', '\x1C', '\x3', '\x2', '\x14', 
		'\x1A', '\x3', '\x2', '\a', '\b', '\x2', 'K', '\x2', '\x16', '\x3', '\x2', 
		'\x2', '\x2', '\x4', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x6', '%', '\x3', 
		'\x2', '\x2', '\x2', '\b', '(', '\x3', '\x2', '\x2', '\x2', '\n', '/', 
		'\x3', '\x2', '\x2', '\x2', '\f', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\xE', '\x33', '\x3', '\x2', '\x2', '\x2', '\x10', '\x36', '\x3', '\x2', 
		'\x2', '\x2', '\x12', '\x38', '\x3', '\x2', '\x2', '\x2', '\x14', 'I', 
		'\x3', '\x2', '\x2', '\x2', '\x16', '\x17', '\x5', '\x4', '\x3', '\x2', 
		'\x17', '\x18', '\x5', '\x6', '\x4', '\x2', '\x18', '\x19', '\a', '\x2', 
		'\x2', '\x3', '\x19', '\x3', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1B', 
		'\x5', '\x12', '\n', '\x2', '\x1B', '\x1C', '\a', '\x3', '\x2', '\x2', 
		'\x1C', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1D', ' ', '\x5', '\b', '\x5', 
		'\x2', '\x1E', ' ', '\x5', '\n', '\x6', '\x2', '\x1F', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', '\x1E', '\x3', '\x2', '\x2', '\x2', ' ', 
		'!', '\x3', '\x2', '\x2', '\x2', '!', '\"', '\a', '\x3', '\x2', '\x2', 
		'\"', '$', '\x3', '\x2', '\x2', '\x2', '#', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '$', '\'', '\x3', '\x2', '\x2', '\x2', '%', '#', '\x3', '\x2', 
		'\x2', '\x2', '%', '&', '\x3', '\x2', '\x2', '\x2', '&', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\'', '%', '\x3', '\x2', '\x2', '\x2', '(', ')', 
		'\a', '\x1D', '\x2', '\x2', ')', '*', '\a', '\x4', '\x2', '\x2', '*', 
		'\t', '\x3', '\x2', '\x2', '\x2', '+', '\x30', '\x5', '\f', '\a', '\x2', 
		',', '\x30', '\x5', '\xE', '\b', '\x2', '-', '\x30', '\x5', '\x14', '\v', 
		'\x2', '.', '\x30', '\x5', '\x10', '\t', '\x2', '/', '+', '\x3', '\x2', 
		'\x2', '\x2', '/', ',', '\x3', '\x2', '\x2', '\x2', '/', '-', '\x3', '\x2', 
		'\x2', '\x2', '/', '.', '\x3', '\x2', '\x2', '\x2', '\x30', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x31', '\x32', '\t', '\x2', '\x2', '\x2', '\x32', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', '\t', '\x3', '\x2', 
		'\x2', '\x34', '\x35', '\a', '\x1D', '\x2', '\x2', '\x35', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x36', '\x37', '\a', '\x10', '\x2', '\x2', '\x37', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x38', ':', '\a', '\x5', '\x2', '\x2', 
		'\x39', ';', '\a', '\t', '\x2', '\x2', ':', '\x39', '\x3', '\x2', '\x2', 
		'\x2', ';', '<', '\x3', '\x2', '\x2', '\x2', '<', ':', '\x3', '\x2', '\x2', 
		'\x2', '<', '=', '\x3', '\x2', '\x2', '\x2', '=', '>', '\x3', '\x2', '\x2', 
		'\x2', '>', '?', '\a', '\x6', '\x2', '\x2', '?', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '@', '\x43', '\a', '\x11', '\x2', '\x2', '\x41', '\x44', 
		'\a', '\t', '\x2', '\x2', '\x42', '\x44', '\x5', '\x12', '\n', '\x2', 
		'\x43', '\x41', '\x3', '\x2', '\x2', '\x2', '\x43', '\x42', '\x3', '\x2', 
		'\x2', '\x2', '\x44', 'J', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', 
		'\a', '\x13', '\x2', '\x2', '\x46', 'J', '\t', '\x4', '\x2', '\x2', 'G', 
		'J', '\a', '\x12', '\x2', '\x2', 'H', 'J', '\a', '\x1B', '\x2', '\x2', 
		'I', '@', '\x3', '\x2', '\x2', '\x2', 'I', '\x45', '\x3', '\x2', '\x2', 
		'\x2', 'I', 'G', '\x3', '\x2', '\x2', '\x2', 'I', 'H', '\x3', '\x2', '\x2', 
		'\x2', 'J', '\x15', '\x3', '\x2', '\x2', '\x2', '\b', '\x1F', '%', '/', 
		'<', '\x43', 'I',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
