using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/MembershipInfo", DoNotGenerateAcw=true)]
	public partial class MembershipInfo : global::Java.Lang.Object, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/MembershipInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MembershipInfo); }
		}

		protected MembershipInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']/constructor[@name='MembershipInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MembershipInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MembershipInfo)) {
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

		static Delegate cb_getGroupId;
#pragma warning disable 0169
		static Delegate GetGetGroupIdHandler ()
		{
			if (cb_getGroupId == null)
				cb_getGroupId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupId);
			return cb_getGroupId;
		}

		static IntPtr n_GetGroupId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.MembershipInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MembershipInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupId);
		}
#pragma warning restore 0169

		static Delegate cb_setGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_setGroupId_Ljava_lang_String_ == null)
				cb_setGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGroupId_Ljava_lang_String_);
			return cb_setGroupId_Ljava_lang_String_;
		}

		static void n_SetGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.MembershipInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MembershipInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupId;
		static IntPtr id_setGroupId_Ljava_lang_String_;
		public virtual unsafe string GroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']/method[@name='getGroupId' and count(parameter)=0]"
			[Register ("getGroupId", "()Ljava/lang/String;", "GetGetGroupIdHandler")]
			get {
				if (id_getGroupId == IntPtr.Zero)
					id_getGroupId = JNIEnv.GetMethodID (class_ref, "getGroupId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getGroupId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']/method[@name='setGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGroupId", "(Ljava/lang/String;)V", "GetSetGroupId_Ljava_lang_String_Handler")]
			set {
				if (id_setGroupId_Ljava_lang_String_ == IntPtr.Zero)
					id_setGroupId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGroupId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setGroupId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGroupId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMemberId;
#pragma warning disable 0169
		static Delegate GetGetMemberIdHandler ()
		{
			if (cb_getMemberId == null)
				cb_getMemberId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMemberId);
			return cb_getMemberId;
		}

		static IntPtr n_GetMemberId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.MembershipInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MembershipInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MemberId);
		}
#pragma warning restore 0169

		static Delegate cb_setMemberId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMemberId_Ljava_lang_String_Handler ()
		{
			if (cb_setMemberId_Ljava_lang_String_ == null)
				cb_setMemberId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMemberId_Ljava_lang_String_);
			return cb_setMemberId_Ljava_lang_String_;
		}

		static void n_SetMemberId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.MembershipInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MembershipInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MemberId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMemberId;
		static IntPtr id_setMemberId_Ljava_lang_String_;
		public virtual unsafe string MemberId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']/method[@name='getMemberId' and count(parameter)=0]"
			[Register ("getMemberId", "()Ljava/lang/String;", "GetGetMemberIdHandler")]
			get {
				if (id_getMemberId == IntPtr.Zero)
					id_getMemberId = JNIEnv.GetMethodID (class_ref, "getMemberId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMemberId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMemberId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']/method[@name='setMemberId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMemberId", "(Ljava/lang/String;)V", "GetSetMemberId_Ljava_lang_String_Handler")]
			set {
				if (id_setMemberId_Ljava_lang_String_ == IntPtr.Zero)
					id_setMemberId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMemberId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMemberId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMemberId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.MembershipInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MembershipInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setStatus_Ljava_lang_String_ == null)
				cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Ljava_lang_String_);
			return cb_setStatus_Ljava_lang_String_;
		}

		static void n_SetStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.MembershipInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MembershipInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_Ljava_lang_String_;
		public virtual unsafe string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")]
			set {
				if (id_setStatus_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStatus_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Ljava/lang/String;)V"), __args);
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
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.MembershipInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MembershipInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_I;
#pragma warning disable 0169
		static Delegate GetSetVersion_IHandler ()
		{
			if (cb_setVersion_I == null)
				cb_setVersion_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetVersion_I);
			return cb_setVersion_I;
		}

		static void n_SetVersion_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Amazon.Clouddrive.Model.MembershipInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MembershipInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Version = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		static IntPtr id_setVersion_I;
		public virtual unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getVersion);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVersion", "(I)V", "GetSetVersion_IHandler")]
			set {
				if (id_setVersion_I == IntPtr.Zero)
					id_setVersion_I = JNIEnv.GetMethodID (class_ref, "setVersion", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVersion_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVersion", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_MembershipInfo_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_MembershipInfo_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_MembershipInfo_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_MembershipInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_MembershipInfo_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_MembershipInfo_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_MembershipInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.MembershipInfo __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MembershipInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.MembershipInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.MembershipInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_MembershipInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='MembershipInfo']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.MembershipInfo']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/MembershipInfo;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_MembershipInfo_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.MembershipInfo p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_MembershipInfo_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_MembershipInfo_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/MembershipInfo;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_MembershipInfo_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/MembershipInfo;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
