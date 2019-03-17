//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace XamAGEmojiKeyboard {
	[Protocol (Name = "AGEmojiKeyboardViewDelegate", WrapperType = typeof (AGEmojiKeyboardViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EmojiKeyBoardView", Selector = "emojiKeyBoardView:didUseEmoji:", ParameterType = new Type [] { typeof (XamAGEmojiKeyboard.AGEmojiKeyboardView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EmojiKeyBoardViewDidPressBackSpace", Selector = "emojiKeyBoardViewDidPressBackSpace:", ParameterType = new Type [] { typeof (XamAGEmojiKeyboard.AGEmojiKeyboardView) }, ParameterByRef = new bool [] { false })]
	public interface IAGEmojiKeyboardViewDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("emojiKeyBoardView:didUseEmoji:")]
		[Preserve (Conditional = true)]
		void EmojiKeyBoardView (AGEmojiKeyboardView emojiKeyBoardView, string emoji);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("emojiKeyBoardViewDidPressBackSpace:")]
		[Preserve (Conditional = true)]
		void EmojiKeyBoardViewDidPressBackSpace (AGEmojiKeyboardView emojiKeyBoardView);
		
	}
	
	internal sealed class AGEmojiKeyboardViewDelegateWrapper : BaseWrapper, IAGEmojiKeyboardViewDelegate {
		[Preserve (Conditional = true)]
		public AGEmojiKeyboardViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("emojiKeyBoardView:didUseEmoji:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EmojiKeyBoardView (AGEmojiKeyboardView emojiKeyBoardView, string emoji)
		{
			if (emojiKeyBoardView == null)
				throw new ArgumentNullException ("emojiKeyBoardView");
			if (emoji == null)
				throw new ArgumentNullException ("emoji");
			var nsemoji = NSString.CreateNative (emoji);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("emojiKeyBoardView:didUseEmoji:"), emojiKeyBoardView.Handle, nsemoji);
			NSString.ReleaseNative (nsemoji);
			
		}
		
		[Export ("emojiKeyBoardViewDidPressBackSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EmojiKeyBoardViewDidPressBackSpace (AGEmojiKeyboardView emojiKeyBoardView)
		{
			if (emojiKeyBoardView == null)
				throw new ArgumentNullException ("emojiKeyBoardView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("emojiKeyBoardViewDidPressBackSpace:"), emojiKeyBoardView.Handle);
		}
		
	}
}
namespace XamAGEmojiKeyboard {
	[Protocol()]
	[Register("AGEmojiKeyboardViewDelegate", false)]
	[Model]
	public unsafe abstract partial class AGEmojiKeyboardViewDelegate : NSObject, IAGEmojiKeyboardViewDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AGEmojiKeyboardViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AGEmojiKeyboardViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AGEmojiKeyboardViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("emojiKeyBoardView:didUseEmoji:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void EmojiKeyBoardView (AGEmojiKeyboardView emojiKeyBoardView, string emoji);
		[Export ("emojiKeyBoardViewDidPressBackSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void EmojiKeyBoardViewDidPressBackSpace (AGEmojiKeyboardView emojiKeyBoardView);
	} /* class AGEmojiKeyboardViewDelegate */
}
