using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='NodeListingResponse']"
	[Register ("com/amazon/clouddrive/model/NodeListingResponse", "", "Com.Amazon.Clouddrive.Model.INodeListingResponseInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.amazon.clouddrive.model.INode"})]
	public partial interface INodeListingResponse : global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse {

		long Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='NodeListingResponse']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()J", "GetGetCountHandler:Com.Amazon.Clouddrive.Model.INodeListingResponseInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='NodeListingResponse']/method[@name='setCount' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCount", "(J)V", "GetSetCount_JHandler:Com.Amazon.Clouddrive.Model.INodeListingResponseInvoker, CloudDriveAPI")] set;
		}

		global::System.Collections.IList Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='NodeListingResponse']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/List;", "GetGetDataHandler:Com.Amazon.Clouddrive.Model.INodeListingResponseInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='NodeListingResponse']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
			[Register ("setData", "(Ljava/util/List;)V", "GetSetData_Ljava_util_List_Handler:Com.Amazon.Clouddrive.Model.INodeListingResponseInvoker, CloudDriveAPI")] set;
		}

		string NextToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='NodeListingResponse']/method[@name='getNextToken' and count(parameter)=0]"
			[Register ("getNextToken", "()Ljava/lang/String;", "GetGetNextTokenHandler:Com.Amazon.Clouddrive.Model.INodeListingResponseInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='NodeListingResponse']/method[@name='setNextToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNextToken", "(Ljava/lang/String;)V", "GetSetNextToken_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.INodeListingResponseInvoker, CloudDriveAPI")] set;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/NodeListingResponse", DoNotGenerateAcw=true)]
	internal class INodeListingResponseInvoker : global::Java.Lang.Object, INodeListingResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/model/NodeListingResponse");
		IntPtr class_ref;

		public static INodeListingResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INodeListingResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.model.NodeListingResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INodeListingResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INodeListingResponseInvoker); }
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCount);
			return cb_getCount;
		}

		static long n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INodeListingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INodeListingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static Delegate cb_setCount_J;
#pragma warning disable 0169
		static Delegate GetSetCount_JHandler ()
		{
			if (cb_setCount_J == null)
				cb_setCount_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetCount_J);
			return cb_setCount_J;
		}

		static void n_SetCount_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Clouddrive.Model.INodeListingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INodeListingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Count = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCount;
		IntPtr id_setCount_J;
		public unsafe long Count {
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getCount);
			}
			set {
				if (id_setCount_J == IntPtr.Zero)
					id_setCount_J = JNIEnv.GetMethodID (class_ref, "setCount", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setCount_J, __args);
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INodeListingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INodeListingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_util_List_Handler ()
		{
			if (cb_setData_Ljava_util_List_ == null)
				cb_setData_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_util_List_);
			return cb_setData_Ljava_util_List_;
		}

		static void n_SetData_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INodeListingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INodeListingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		IntPtr id_getData;
		IntPtr id_setData_Ljava_util_List_;
		public unsafe global::System.Collections.IList Data {
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setData_Ljava_util_List_ == IntPtr.Zero)
					id_setData_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setData_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getNextToken;
#pragma warning disable 0169
		static Delegate GetGetNextTokenHandler ()
		{
			if (cb_getNextToken == null)
				cb_getNextToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextToken);
			return cb_getNextToken;
		}

		static IntPtr n_GetNextToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INodeListingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INodeListingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextToken);
		}
#pragma warning restore 0169

		static Delegate cb_setNextToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNextToken_Ljava_lang_String_Handler ()
		{
			if (cb_setNextToken_Ljava_lang_String_ == null)
				cb_setNextToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNextToken_Ljava_lang_String_);
			return cb_setNextToken_Ljava_lang_String_;
		}

		static void n_SetNextToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INodeListingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INodeListingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NextToken = p0;
		}
#pragma warning restore 0169

		IntPtr id_getNextToken;
		IntPtr id_setNextToken_Ljava_lang_String_;
		public unsafe string NextToken {
			get {
				if (id_getNextToken == IntPtr.Zero)
					id_getNextToken = JNIEnv.GetMethodID (class_ref, "getNextToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getNextToken), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setNextToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setNextToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNextToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setNextToken_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_another)
		{
			global::Com.Amazon.Clouddrive.Model.INodeListingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INodeListingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object another = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_another, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (another);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_compareTo_Ljava_lang_Object_;
		public unsafe global::System.Int32 CompareTo (global::Java.Lang.Object another)
		{
			if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (another);
			global::System.Int32 __ret = JNIEnv.CallIntMethod (Handle, id_compareTo_Ljava_lang_Object_, __args);
			return __ret;
		}

	}

}
