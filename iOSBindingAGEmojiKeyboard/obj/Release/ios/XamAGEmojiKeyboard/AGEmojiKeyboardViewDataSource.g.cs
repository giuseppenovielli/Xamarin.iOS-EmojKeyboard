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
	[Protocol (Name = "AGEmojiKeyboardViewDataSource", WrapperType = typeof (AGEmojiKeyboardViewDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EmojiKeyboardView", Selector = "emojiKeyboardView:imageForSelectedCategory:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (XamAGEmojiKeyboard.AGEmojiKeyboardView), typeof (XamAGEmojiKeyboard.AGEmojiKeyboardViewCategoryImage) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EmojiKeyboardViewNonSelected", Selector = "emojiKeyboardViewNonSelected:imageForNonSelectedCategory:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (XamAGEmojiKeyboard.AGEmojiKeyboardView), typeof (XamAGEmojiKeyboard.AGEmojiKeyboardViewCategoryImage) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BackSpaceButtonImageForEmojiKeyboardView", Selector = "backSpaceButtonImageForEmojiKeyboardView:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (XamAGEmojiKeyboard.AGEmojiKeyboardView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DefaultCategoryForEmojiKeyboardView", Selector = "defaultCategoryForEmojiKeyboardView:", ReturnType = typeof (XamAGEmojiKeyboard.AGEmojiKeyboardViewCategoryImage), ParameterType = new Type [] { typeof (XamAGEmojiKeyboard.AGEmojiKeyboardView) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecentEmojisMaintainedCountForEmojiKeyboardView", Selector = "recentEmojisMaintainedCountForEmojiKeyboardView:", ReturnType = typeof (nuint), ParameterType = new Type [] { typeof (XamAGEmojiKeyboard.AGEmojiKeyboardView) }, ParameterByRef = new bool [] { false })]
	public interface IAGEmojiKeyboardViewDataSource : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("emojiKeyboardView:imageForSelectedCategory:")]
		[Preserve (Conditional = true)]
		global::UIKit.UIImage EmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView, AGEmojiKeyboardViewCategoryImage category);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("emojiKeyboardViewNonSelected:imageForNonSelectedCategory:")]
		[Preserve (Conditional = true)]
		global::UIKit.UIImage EmojiKeyboardViewNonSelected (AGEmojiKeyboardView emojiKeyboardView, AGEmojiKeyboardViewCategoryImage category);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("backSpaceButtonImageForEmojiKeyboardView:")]
		[Preserve (Conditional = true)]
		global::UIKit.UIImage BackSpaceButtonImageForEmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView);
		
	}
	
	public static partial class AGEmojiKeyboardViewDataSource_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AGEmojiKeyboardViewCategoryImage DefaultCategoryForEmojiKeyboardView (this IAGEmojiKeyboardViewDataSource This, AGEmojiKeyboardView emojiKeyboardView)
		{
			if (emojiKeyboardView == null)
				throw new ArgumentNullException ("emojiKeyboardView");
			AGEmojiKeyboardViewCategoryImage ret;
			if (IntPtr.Size == 8) {
				ret = (AGEmojiKeyboardViewCategoryImage) global::ApiDefinitions.Messaging.Int64_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("defaultCategoryForEmojiKeyboardView:"), emojiKeyboardView.Handle);
			} else {
				ret = (AGEmojiKeyboardViewCategoryImage) global::ApiDefinitions.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("defaultCategoryForEmojiKeyboardView:"), emojiKeyboardView.Handle);
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint RecentEmojisMaintainedCountForEmojiKeyboardView (this IAGEmojiKeyboardViewDataSource This, AGEmojiKeyboardView emojiKeyboardView)
		{
			if (emojiKeyboardView == null)
				throw new ArgumentNullException ("emojiKeyboardView");
			return global::ApiDefinitions.Messaging.nuint_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("recentEmojisMaintainedCountForEmojiKeyboardView:"), emojiKeyboardView.Handle);
		}
		
	}
	
	internal sealed class AGEmojiKeyboardViewDataSourceWrapper : BaseWrapper, IAGEmojiKeyboardViewDataSource {
		[Preserve (Conditional = true)]
		public AGEmojiKeyboardViewDataSourceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("emojiKeyboardView:imageForSelectedCategory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIImage EmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView, AGEmojiKeyboardViewCategoryImage category)
		{
			if (emojiKeyboardView == null)
				throw new ArgumentNullException ("emojiKeyboardView");
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_Int64 (this.Handle, Selector.GetHandle ("emojiKeyboardView:imageForSelectedCategory:"), emojiKeyboardView.Handle, (Int64)category));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("emojiKeyboardView:imageForSelectedCategory:"), emojiKeyboardView.Handle, (int)category));
			}
		}
		
		[Export ("emojiKeyboardViewNonSelected:imageForNonSelectedCategory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIImage EmojiKeyboardViewNonSelected (AGEmojiKeyboardView emojiKeyboardView, AGEmojiKeyboardViewCategoryImage category)
		{
			if (emojiKeyboardView == null)
				throw new ArgumentNullException ("emojiKeyboardView");
			if (IntPtr.Size == 8) {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_Int64 (this.Handle, Selector.GetHandle ("emojiKeyboardViewNonSelected:imageForNonSelectedCategory:"), emojiKeyboardView.Handle, (Int64)category));
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("emojiKeyboardViewNonSelected:imageForNonSelectedCategory:"), emojiKeyboardView.Handle, (int)category));
			}
		}
		
		[Export ("backSpaceButtonImageForEmojiKeyboardView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIImage BackSpaceButtonImageForEmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView)
		{
			if (emojiKeyboardView == null)
				throw new ArgumentNullException ("emojiKeyboardView");
			return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("backSpaceButtonImageForEmojiKeyboardView:"), emojiKeyboardView.Handle));
		}
		
	}
}
namespace XamAGEmojiKeyboard {
	[Protocol()]
	[Register("AGEmojiKeyboardViewDataSource", false)]
	[Model]
	public unsafe abstract partial class AGEmojiKeyboardViewDataSource : NSObject, IAGEmojiKeyboardViewDataSource {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AGEmojiKeyboardViewDataSource () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AGEmojiKeyboardViewDataSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AGEmojiKeyboardViewDataSource (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("backSpaceButtonImageForEmojiKeyboardView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract global::UIKit.UIImage BackSpaceButtonImageForEmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView);
		[Export ("defaultCategoryForEmojiKeyboardView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AGEmojiKeyboardViewCategoryImage DefaultCategoryForEmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("emojiKeyboardView:imageForSelectedCategory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract global::UIKit.UIImage EmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView, AGEmojiKeyboardViewCategoryImage category);
		[Export ("emojiKeyboardViewNonSelected:imageForNonSelectedCategory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract global::UIKit.UIImage EmojiKeyboardViewNonSelected (AGEmojiKeyboardView emojiKeyboardView, AGEmojiKeyboardViewCategoryImage category);
		[Export ("recentEmojisMaintainedCountForEmojiKeyboardView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint RecentEmojisMaintainedCountForEmojiKeyboardView (AGEmojiKeyboardView emojiKeyboardView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class AGEmojiKeyboardViewDataSource */
}
