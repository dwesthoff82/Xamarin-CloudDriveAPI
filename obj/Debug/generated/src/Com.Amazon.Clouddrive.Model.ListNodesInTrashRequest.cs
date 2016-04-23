using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/ListNodesInTrashRequest", DoNotGenerateAcw=true)]
	public partial class ListNodesInTrashRequest : global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/ListNodesInTrashRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListNodesInTrashRequest); }
		}

		protected ListNodesInTrashRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashRequest']/constructor[@name='ListNodesInTrashRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ListNodesInTrashRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ListNodesInTrashRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_withFields_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithFields_Ljava_lang_String_Handler ()
		{
			if (cb_withFields_Ljava_lang_String_ == null)
				cb_withFields_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFields_Ljava_lang_String_);
			return cb_withFields_Ljava_lang_String_;
		}

		static IntPtr n_WithFields_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFields (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFields_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashRequest']/method[@name='withFields' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withFields", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;", "GetWithFields_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest WithFields (string p0)
		{
			if (id_withFields_Ljava_lang_String_ == IntPtr.Zero)
				id_withFields_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withFields", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallObjectMethod  (Handle, id_withFields_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFields", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withFilters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithFilters_Ljava_lang_String_Handler ()
		{
			if (cb_withFilters_Ljava_lang_String_ == null)
				cb_withFilters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFilters_Ljava_lang_String_);
			return cb_withFilters_Ljava_lang_String_;
		}

		static IntPtr n_WithFilters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFilters (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFilters_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashRequest']/method[@name='withFilters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withFilters", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;", "GetWithFilters_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest WithFilters (string p0)
		{
			if (id_withFilters_Ljava_lang_String_ == IntPtr.Zero)
				id_withFilters_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withFilters", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallObjectMethod  (Handle, id_withFilters_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFilters", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withLimit_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetWithLimit_Ljava_lang_Integer_Handler ()
		{
			if (cb_withLimit_Ljava_lang_Integer_ == null)
				cb_withLimit_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLimit_Ljava_lang_Integer_);
			return cb_withLimit_Ljava_lang_Integer_;
		}

		static IntPtr n_WithLimit_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLimit (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withLimit_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashRequest']/method[@name='withLimit' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("withLimit", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;", "GetWithLimit_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest WithLimit (global::Java.Lang.Integer p0)
		{
			if (id_withLimit_Ljava_lang_Integer_ == IntPtr.Zero)
				id_withLimit_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withLimit", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallObjectMethod  (Handle, id_withLimit_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withLimit", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOffset_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetWithOffset_Ljava_lang_Integer_Handler ()
		{
			if (cb_withOffset_Ljava_lang_Integer_ == null)
				cb_withOffset_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOffset_Ljava_lang_Integer_);
			return cb_withOffset_Ljava_lang_Integer_;
		}

		static IntPtr n_WithOffset_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOffset (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOffset_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashRequest']/method[@name='withOffset' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("withOffset", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;", "GetWithOffset_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest WithOffset (global::Java.Lang.Integer p0)
		{
			if (id_withOffset_Ljava_lang_Integer_ == IntPtr.Zero)
				id_withOffset_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withOffset", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallObjectMethod  (Handle, id_withOffset_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOffset", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withSort_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithSort_Ljava_lang_String_Handler ()
		{
			if (cb_withSort_Ljava_lang_String_ == null)
				cb_withSort_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSort_Ljava_lang_String_);
			return cb_withSort_Ljava_lang_String_;
		}

		static IntPtr n_WithSort_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSort (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSort_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashRequest']/method[@name='withSort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSort", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;", "GetWithSort_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest WithSort (string p0)
		{
			if (id_withSort_Ljava_lang_String_ == IntPtr.Zero)
				id_withSort_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withSort", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallObjectMethod  (Handle, id_withSort_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSort", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withStartToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithStartToken_Ljava_lang_String_Handler ()
		{
			if (cb_withStartToken_Ljava_lang_String_ == null)
				cb_withStartToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithStartToken_Ljava_lang_String_);
			return cb_withStartToken_Ljava_lang_String_;
		}

		static IntPtr n_WithStartToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithStartToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withStartToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashRequest']/method[@name='withStartToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withStartToken", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;", "GetWithStartToken_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest WithStartToken (string p0)
		{
			if (id_withStartToken_Ljava_lang_String_ == IntPtr.Zero)
				id_withStartToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withStartToken", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallObjectMethod  (Handle, id_withStartToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withStartToken", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListNodesInTrashRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
