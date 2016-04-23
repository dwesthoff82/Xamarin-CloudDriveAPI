using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='Optional']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/utils/Optional", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class Optional : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='Optional.None']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/utils/Optional$None", DoNotGenerateAcw=true)]
		public sealed partial class None : global::Com.Amazon.Clouddrive.Utils.Optional {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/clouddrive/utils/Optional$None", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (None); }
			}

			internal None (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='Optional.None']/method[@name='get' and count(parameter)=0]"
			[Register ("get", "()Ljava/lang/Object;", "")]
			public override unsafe global::Java.Lang.Object Get ()
			{
				if (id_get == IntPtr.Zero)
					id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='Optional.Some']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/utils/Optional$Some", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public sealed partial class Some : global::Com.Amazon.Clouddrive.Utils.Optional {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/amazon/clouddrive/utils/Optional$Some", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Some); }
			}

			internal Some (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='Optional.Some']/method[@name='get' and count(parameter)=0]"
			[Register ("get", "()Ljava/lang/Object;", "")]
			public override unsafe global::Java.Lang.Object Get ()
			{
				if (id_get == IntPtr.Zero)
					id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/utils/Optional", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Optional); }
		}

		protected Optional (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isPresent;
		public unsafe bool IsPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='Optional']/method[@name='isPresent' and count(parameter)=0]"
			[Register ("isPresent", "()Z", "GetIsPresentHandler")]
			get {
				if (id_isPresent == IntPtr.Zero)
					id_isPresent = JNIEnv.GetMethodID (class_ref, "isPresent", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isPresent);
				} finally {
				}
			}
		}

		static IntPtr id_absent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='Optional']/method[@name='absent' and count(parameter)=0]"
		[Register ("absent", "()Lcom/amazon/clouddrive/utils/Optional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe global::Com.Amazon.Clouddrive.Utils.Optional Absent ()
		{
			if (id_absent == IntPtr.Zero)
				id_absent = JNIEnv.GetStaticMethodID (class_ref, "absent", "()Lcom/amazon/clouddrive/utils/Optional;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Utils.Optional> (JNIEnv.CallStaticObjectMethod  (class_ref, id_absent), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Utils.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Utils.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='Optional']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public abstract global::Java.Lang.Object Get ();

		static IntPtr id_of_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='Optional']/method[@name='of' and count(parameter)=1 and parameter[1][@type='V']]"
		[Register ("of", "(Ljava/lang/Object;)Lcom/amazon/clouddrive/utils/Optional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
		public static unsafe global::Com.Amazon.Clouddrive.Utils.Optional Of (global::Java.Lang.Object p0)
		{
			if (id_of_Ljava_lang_Object_ == IntPtr.Zero)
				id_of_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "of", "(Ljava/lang/Object;)Lcom/amazon/clouddrive/utils/Optional;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Amazon.Clouddrive.Utils.Optional __ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Utils.Optional> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/utils/Optional", DoNotGenerateAcw=true)]
	internal partial class OptionalInvoker : Optional {

		public OptionalInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OptionalInvoker); }
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.utils']/class[@name='Optional']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public override unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
