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
	[Protocol (Name = "AGEmojiPageViewDelegate", WrapperType = typeof (AGEmojiPageViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EmojiPageView", Selector = "emojiPageView:didUseEmoji:", ParameterType = new Type [] { typeof (XamAGEmojiKeyboard.AGEmojiPageView), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EmojiPageViewDidPressBackSpace", Selector = "emojiPageViewDidPressBackSpace:", ParameterType = new Type [] { typeof (XamAGEmojiKeyboard.AGEmojiPageView) }, ParameterByRef = new bool [] { false })]
	public interface IAGEmojiPageViewDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("emojiPageView:didUseEmoji:")]
		[Preserve (Conditional = true)]
		void EmojiPageView (AGEmojiPageView emojiPageView, string emoji);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("emojiPageViewDidPressBackSpace:")]
		[Preserve (Conditional = true)]
		void EmojiPageViewDidPressBackSpace (AGEmojiPageView emojiPageView);
		
	}
	
	internal sealed class AGEmojiPageViewDelegateWrapper : BaseWrapper, IAGEmojiPageViewDelegate {
		[Preserve (Conditional = true)]
		public AGEmojiPageViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("emojiPageView:didUseEmoji:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EmojiPageView (AGEmojiPageView emojiPageView, string emoji)
		{
			if (emojiPageView == null)
				throw new ArgumentNullException ("emojiPageView");
			if (emoji == null)
				throw new ArgumentNullException ("emoji");
			var nsemoji = NSString.CreateNative (emoji);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("emojiPageView:didUseEmoji:"), emojiPageView.Handle, nsemoji);
			NSString.ReleaseNative (nsemoji);
			
		}
		
		[Export ("emojiPageViewDidPressBackSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EmojiPageViewDidPressBackSpace (AGEmojiPageView emojiPageView)
		{
			if (emojiPageView == null)
				throw new ArgumentNullException ("emojiPageView");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("emojiPageViewDidPressBackSpace:"), emojiPageView.Handle);
		}
		
	}
}
namespace XamAGEmojiKeyboard {
	[Protocol()]
	[Register("AGEmojiPageViewDelegate", false)]
	[Model]
	public unsafe abstract partial class AGEmojiPageViewDelegate : NSObject, IAGEmojiPageViewDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AGEmojiPageViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AGEmojiPageViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AGEmojiPageViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("emojiPageView:didUseEmoji:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void EmojiPageView (AGEmojiPageView emojiPageView, string emoji);
		[Export ("emojiPageViewDidPressBackSpace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void EmojiPageViewDidPressBackSpace (AGEmojiPageView emojiPageView);
	} /* class AGEmojiPageViewDelegate */
}
