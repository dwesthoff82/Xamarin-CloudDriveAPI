using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='CloudDriveResponse']"
	[Register ("com/amazon/clouddrive/model/CloudDriveResponse", "", "Com.Amazon.Clouddrive.Model.ICloudDriveResponseInvoker")]
	public partial interface ICloudDriveResponse : global::Java.Lang.IComparable {

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/CloudDriveResponse", DoNotGenerateAcw=true)]
	internal class ICloudDriveResponseInvoker : global::Java.Lang.Object, ICloudDriveResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/model/CloudDriveResponse");
		IntPtr class_ref;

		public static ICloudDriveResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloudDriveResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.model.CloudDriveResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloudDriveResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICloudDriveResponseInvoker); }
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
			global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
