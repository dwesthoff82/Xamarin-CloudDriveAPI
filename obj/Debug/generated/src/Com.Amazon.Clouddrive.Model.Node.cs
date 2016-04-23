using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/Node", DoNotGenerateAcw=true)]
	public partial class Node : global::Com.Amazon.Clouddrive.Model.EditableNode, global::Com.Amazon.Clouddrive.Model.INode {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/Node", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Node); }
		}

		protected Node (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/constructor[@name='Node' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Node ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Node)) {
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

		static Delegate cb_getAssets;
#pragma warning disable 0169
		static Delegate GetGetAssetsHandler ()
		{
			if (cb_getAssets == null)
				cb_getAssets = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAssets);
			return cb_getAssets;
		}

		static IntPtr n_GetAssets (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.ToLocalJniHandle (__this.Assets);
		}
#pragma warning restore 0169

		static Delegate cb_setAssets_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAssets_Ljava_util_List_Handler ()
		{
			if (cb_setAssets_Ljava_util_List_ == null)
				cb_setAssets_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAssets_Ljava_util_List_);
			return cb_setAssets_Ljava_util_List_;
		}

		static void n_SetAssets_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Assets = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAssets;
		static IntPtr id_setAssets_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Amazon.Clouddrive.Model.Node> Assets {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='getAssets' and count(parameter)=0]"
			[Register ("getAssets", "()Ljava/util/List;", "GetGetAssetsHandler")]
			get {
				if (id_getAssets == IntPtr.Zero)
					id_getAssets = JNIEnv.GetMethodID (class_ref, "getAssets", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAssets), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAssets", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setAssets' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.amazon.clouddrive.model.Node&gt;']]"
			[Register ("setAssets", "(Ljava/util/List;)V", "GetSetAssets_Ljava_util_List_Handler")]
			set {
				if (id_setAssets_Ljava_util_List_ == IntPtr.Zero)
					id_setAssets_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAssets", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAssets_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAssets", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCreatedBy;
#pragma warning disable 0169
		static Delegate GetGetCreatedByHandler ()
		{
			if (cb_getCreatedBy == null)
				cb_getCreatedBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedBy);
			return cb_getCreatedBy;
		}

		static IntPtr n_GetCreatedBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreatedBy);
		}
#pragma warning restore 0169

		static Delegate cb_setCreatedBy_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCreatedBy_Ljava_lang_String_Handler ()
		{
			if (cb_setCreatedBy_Ljava_lang_String_ == null)
				cb_setCreatedBy_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreatedBy_Ljava_lang_String_);
			return cb_setCreatedBy_Ljava_lang_String_;
		}

		static void n_SetCreatedBy_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreatedBy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedBy;
		static IntPtr id_setCreatedBy_Ljava_lang_String_;
		public virtual unsafe string CreatedBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='getCreatedBy' and count(parameter)=0]"
			[Register ("getCreatedBy", "()Ljava/lang/String;", "GetGetCreatedByHandler")]
			get {
				if (id_getCreatedBy == IntPtr.Zero)
					id_getCreatedBy = JNIEnv.GetMethodID (class_ref, "getCreatedBy", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCreatedBy), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreatedBy", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setCreatedBy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCreatedBy", "(Ljava/lang/String;)V", "GetSetCreatedBy_Ljava_lang_String_Handler")]
			set {
				if (id_setCreatedBy_Ljava_lang_String_ == IntPtr.Zero)
					id_setCreatedBy_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCreatedBy", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCreatedBy_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreatedBy", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCreatedDate;
#pragma warning disable 0169
		static Delegate GetGetCreatedDateHandler ()
		{
			if (cb_getCreatedDate == null)
				cb_getCreatedDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedDate);
			return cb_getCreatedDate;
		}

		static IntPtr n_GetCreatedDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreatedDate);
		}
#pragma warning restore 0169

		static Delegate cb_setCreatedDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCreatedDate_Ljava_lang_String_Handler ()
		{
			if (cb_setCreatedDate_Ljava_lang_String_ == null)
				cb_setCreatedDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreatedDate_Ljava_lang_String_);
			return cb_setCreatedDate_Ljava_lang_String_;
		}

		static void n_SetCreatedDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreatedDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedDate;
		static IntPtr id_setCreatedDate_Ljava_lang_String_;
		public virtual unsafe string CreatedDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='getCreatedDate' and count(parameter)=0]"
			[Register ("getCreatedDate", "()Ljava/lang/String;", "GetGetCreatedDateHandler")]
			get {
				if (id_getCreatedDate == IntPtr.Zero)
					id_getCreatedDate = JNIEnv.GetMethodID (class_ref, "getCreatedDate", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCreatedDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreatedDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setCreatedDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCreatedDate", "(Ljava/lang/String;)V", "GetSetCreatedDate_Ljava_lang_String_Handler")]
			set {
				if (id_setCreatedDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setCreatedDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCreatedDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCreatedDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreatedDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getETagRequest;
#pragma warning disable 0169
		static Delegate GetGetETagRequestHandler ()
		{
			if (cb_getETagRequest == null)
				cb_getETagRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetETagRequest);
			return cb_getETagRequest;
		}

		static IntPtr n_GetETagRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETagRequest);
		}
#pragma warning restore 0169

		static Delegate cb_setETagRequest_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetETagRequest_Ljava_lang_String_Handler ()
		{
			if (cb_setETagRequest_Ljava_lang_String_ == null)
				cb_setETagRequest_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetETagRequest_Ljava_lang_String_);
			return cb_setETagRequest_Ljava_lang_String_;
		}

		static void n_SetETagRequest_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ETagRequest = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getETagRequest;
		static IntPtr id_setETagRequest_Ljava_lang_String_;
		public virtual unsafe string ETagRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='getETagRequest' and count(parameter)=0]"
			[Register ("getETagRequest", "()Ljava/lang/String;", "GetGetETagRequestHandler")]
			get {
				if (id_getETagRequest == IntPtr.Zero)
					id_getETagRequest = JNIEnv.GetMethodID (class_ref, "getETagRequest", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getETagRequest), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getETagRequest", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setETagRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setETagRequest", "(Ljava/lang/String;)V", "GetSetETagRequest_Ljava_lang_String_Handler")]
			set {
				if (id_setETagRequest_Ljava_lang_String_ == IntPtr.Zero)
					id_setETagRequest_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setETagRequest", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setETagRequest_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setETagRequest", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getETagResponse;
#pragma warning disable 0169
		static Delegate GetGetETagResponseHandler ()
		{
			if (cb_getETagResponse == null)
				cb_getETagResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetETagResponse);
			return cb_getETagResponse;
		}

		static IntPtr n_GetETagResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETagResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setETagResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetETagResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setETagResponse_Ljava_lang_String_ == null)
				cb_setETagResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetETagResponse_Ljava_lang_String_);
			return cb_setETagResponse_Ljava_lang_String_;
		}

		static void n_SetETagResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ETagResponse = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getETagResponse;
		static IntPtr id_setETagResponse_Ljava_lang_String_;
		public virtual unsafe string ETagResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='getETagResponse' and count(parameter)=0]"
			[Register ("getETagResponse", "()Ljava/lang/String;", "GetGetETagResponseHandler")]
			get {
				if (id_getETagResponse == IntPtr.Zero)
					id_getETagResponse = JNIEnv.GetMethodID (class_ref, "getETagResponse", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getETagResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getETagResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setETagResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setETagResponse", "(Ljava/lang/String;)V", "GetSetETagResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setETagResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setETagResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setETagResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setETagResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setETagResponse", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getModifiedDate;
#pragma warning disable 0169
		static Delegate GetGetModifiedDateHandler ()
		{
			if (cb_getModifiedDate == null)
				cb_getModifiedDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModifiedDate);
			return cb_getModifiedDate;
		}

		static IntPtr n_GetModifiedDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ModifiedDate);
		}
#pragma warning restore 0169

		static Delegate cb_setModifiedDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetModifiedDate_Ljava_lang_String_Handler ()
		{
			if (cb_setModifiedDate_Ljava_lang_String_ == null)
				cb_setModifiedDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetModifiedDate_Ljava_lang_String_);
			return cb_setModifiedDate_Ljava_lang_String_;
		}

		static void n_SetModifiedDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ModifiedDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getModifiedDate;
		static IntPtr id_setModifiedDate_Ljava_lang_String_;
		public virtual unsafe string ModifiedDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='getModifiedDate' and count(parameter)=0]"
			[Register ("getModifiedDate", "()Ljava/lang/String;", "GetGetModifiedDateHandler")]
			get {
				if (id_getModifiedDate == IntPtr.Zero)
					id_getModifiedDate = JNIEnv.GetMethodID (class_ref, "getModifiedDate", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getModifiedDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModifiedDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setModifiedDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setModifiedDate", "(Ljava/lang/String;)V", "GetSetModifiedDate_Ljava_lang_String_Handler")]
			set {
				if (id_setModifiedDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setModifiedDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setModifiedDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setModifiedDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModifiedDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTempLink;
#pragma warning disable 0169
		static Delegate GetGetTempLinkHandler ()
		{
			if (cb_getTempLink == null)
				cb_getTempLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTempLink);
			return cb_getTempLink;
		}

		static IntPtr n_GetTempLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TempLink);
		}
#pragma warning restore 0169

		static Delegate cb_setTempLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTempLink_Ljava_lang_String_Handler ()
		{
			if (cb_setTempLink_Ljava_lang_String_ == null)
				cb_setTempLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTempLink_Ljava_lang_String_);
			return cb_setTempLink_Ljava_lang_String_;
		}

		static void n_SetTempLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TempLink = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTempLink;
		static IntPtr id_setTempLink_Ljava_lang_String_;
		public virtual unsafe string TempLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='getTempLink' and count(parameter)=0]"
			[Register ("getTempLink", "()Ljava/lang/String;", "GetGetTempLinkHandler")]
			get {
				if (id_getTempLink == IntPtr.Zero)
					id_getTempLink = JNIEnv.GetMethodID (class_ref, "getTempLink", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTempLink), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTempLink", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setTempLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTempLink", "(Ljava/lang/String;)V", "GetSetTempLink_Ljava_lang_String_Handler")]
			set {
				if (id_setTempLink_Ljava_lang_String_ == IntPtr.Zero)
					id_setTempLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTempLink", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTempLink_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTempLink", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetVersion);
			return cb_getVersion;
		}

		static long n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_J;
#pragma warning disable 0169
		static Delegate GetSetVersion_JHandler ()
		{
			if (cb_setVersion_J == null)
				cb_setVersion_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetVersion_J);
			return cb_setVersion_J;
		}

		static void n_SetVersion_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Version = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		static IntPtr id_setVersion_J;
		public virtual unsafe long Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()J", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getVersion);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setVersion", "(J)V", "GetSetVersion_JHandler")]
			set {
				if (id_setVersion_J == IntPtr.Zero)
					id_setVersion_J = JNIEnv.GetMethodID (class_ref, "setVersion", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVersion_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVersion", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isExclusivelyTrashed;
#pragma warning disable 0169
		static Delegate GetIsExclusivelyTrashedHandler ()
		{
			if (cb_isExclusivelyTrashed == null)
				cb_isExclusivelyTrashed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsExclusivelyTrashed);
			return cb_isExclusivelyTrashed;
		}

		static IntPtr n_IsExclusivelyTrashed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsExclusivelyTrashed ());
		}
#pragma warning restore 0169

		static IntPtr id_isExclusivelyTrashed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='isExclusivelyTrashed' and count(parameter)=0]"
		[Register ("isExclusivelyTrashed", "()Ljava/lang/Boolean;", "GetIsExclusivelyTrashedHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsExclusivelyTrashed ()
		{
			if (id_isExclusivelyTrashed == IntPtr.Zero)
				id_isExclusivelyTrashed = JNIEnv.GetMethodID (class_ref, "isExclusivelyTrashed", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isExclusivelyTrashed), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExclusivelyTrashed", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isRecursivelyTrashed;
#pragma warning disable 0169
		static Delegate GetIsRecursivelyTrashedHandler ()
		{
			if (cb_isRecursivelyTrashed == null)
				cb_isRecursivelyTrashed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsRecursivelyTrashed);
			return cb_isRecursivelyTrashed;
		}

		static IntPtr n_IsRecursivelyTrashed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsRecursivelyTrashed ());
		}
#pragma warning restore 0169

		static IntPtr id_isRecursivelyTrashed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='isRecursivelyTrashed' and count(parameter)=0]"
		[Register ("isRecursivelyTrashed", "()Ljava/lang/Boolean;", "GetIsRecursivelyTrashedHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsRecursivelyTrashed ()
		{
			if (id_isRecursivelyTrashed == IntPtr.Zero)
				id_isRecursivelyTrashed = JNIEnv.GetMethodID (class_ref, "isRecursivelyTrashed", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isRecursivelyTrashed), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRecursivelyTrashed", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isRoot;
#pragma warning disable 0169
		static Delegate GetIsRootHandler ()
		{
			if (cb_isRoot == null)
				cb_isRoot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsRoot);
			return cb_isRoot;
		}

		static IntPtr n_IsRoot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsRoot ());
		}
#pragma warning restore 0169

		static IntPtr id_isRoot;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='isRoot' and count(parameter)=0]"
		[Register ("isRoot", "()Ljava/lang/Boolean;", "GetIsRootHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsRoot ()
		{
			if (id_isRoot == IntPtr.Zero)
				id_isRoot = JNIEnv.GetMethodID (class_ref, "isRoot", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isRoot), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRoot", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isShared;
#pragma warning disable 0169
		static Delegate GetIsSharedHandler ()
		{
			if (cb_isShared == null)
				cb_isShared = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsShared);
			return cb_isShared;
		}

		static IntPtr n_IsShared (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsShared ());
		}
#pragma warning restore 0169

		static IntPtr id_isShared;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='isShared' and count(parameter)=0]"
		[Register ("isShared", "()Ljava/lang/Boolean;", "GetIsSharedHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsShared ()
		{
			if (id_isShared == IntPtr.Zero)
				id_isShared = JNIEnv.GetMethodID (class_ref, "isShared", "()Ljava/lang/Boolean;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_isShared), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShared", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setExclusivelyTrashed_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetExclusivelyTrashed_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setExclusivelyTrashed_Ljava_lang_Boolean_ == null)
				cb_setExclusivelyTrashed_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExclusivelyTrashed_Ljava_lang_Boolean_);
			return cb_setExclusivelyTrashed_Ljava_lang_Boolean_;
		}

		static void n_SetExclusivelyTrashed_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExclusivelyTrashed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExclusivelyTrashed_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setExclusivelyTrashed' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setExclusivelyTrashed", "(Ljava/lang/Boolean;)V", "GetSetExclusivelyTrashed_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetExclusivelyTrashed (global::Java.Lang.Boolean p0)
		{
			if (id_setExclusivelyTrashed_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setExclusivelyTrashed_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setExclusivelyTrashed", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExclusivelyTrashed_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExclusivelyTrashed", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIsRoot_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetIsRoot_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setIsRoot_Ljava_lang_Boolean_ == null)
				cb_setIsRoot_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsRoot_Ljava_lang_Boolean_);
			return cb_setIsRoot_Ljava_lang_Boolean_;
		}

		static void n_SetIsRoot_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIsRoot (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIsRoot_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setIsRoot' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setIsRoot", "(Ljava/lang/Boolean;)V", "GetSetIsRoot_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetIsRoot (global::Java.Lang.Boolean p0)
		{
			if (id_setIsRoot_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setIsRoot_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setIsRoot", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIsRoot_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsRoot", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIsShared_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetIsShared_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setIsShared_Ljava_lang_Boolean_ == null)
				cb_setIsShared_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsShared_Ljava_lang_Boolean_);
			return cb_setIsShared_Ljava_lang_Boolean_;
		}

		static void n_SetIsShared_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIsShared (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIsShared_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setIsShared' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setIsShared", "(Ljava/lang/Boolean;)V", "GetSetIsShared_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetIsShared (global::Java.Lang.Boolean p0)
		{
			if (id_setIsShared_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setIsShared_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setIsShared", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIsShared_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsShared", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRecursivelyTrashed_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetRecursivelyTrashed_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setRecursivelyTrashed_Ljava_lang_Boolean_ == null)
				cb_setRecursivelyTrashed_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecursivelyTrashed_Ljava_lang_Boolean_);
			return cb_setRecursivelyTrashed_Ljava_lang_Boolean_;
		}

		static void n_SetRecursivelyTrashed_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.Node __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.Node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRecursivelyTrashed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRecursivelyTrashed_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='Node']/method[@name='setRecursivelyTrashed' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setRecursivelyTrashed", "(Ljava/lang/Boolean;)V", "GetSetRecursivelyTrashed_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetRecursivelyTrashed (global::Java.Lang.Boolean p0)
		{
			if (id_setRecursivelyTrashed_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setRecursivelyTrashed_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setRecursivelyTrashed", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRecursivelyTrashed_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecursivelyTrashed", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

	}
}
