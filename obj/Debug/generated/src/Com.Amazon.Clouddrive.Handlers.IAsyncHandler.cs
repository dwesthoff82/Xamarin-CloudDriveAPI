using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Handlers {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.handlers']/interface[@name='AsyncHandler']"
	[Register ("com/amazon/clouddrive/handlers/AsyncHandler", "", "Com.Amazon.Clouddrive.Handlers.IAsyncHandlerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"REQUEST extends com.amazon.clouddrive.model.CloudDriveRequest", "RESULT"})]
	public partial interface IAsyncHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.handlers']/interface[@name='AsyncHandler']/method[@name='onCanceled' and count(parameter)=1 and parameter[1][@type='REQUEST']]"
		[Register ("onCanceled", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)V", "GetOnCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_Handler:Com.Amazon.Clouddrive.Handlers.IAsyncHandlerInvoker, CloudDriveAPI")]
		void OnCanceled (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.handlers']/interface[@name='AsyncHandler']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='REQUEST'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onError", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;Ljava/lang/Exception;)V", "GetOnError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_Handler:Com.Amazon.Clouddrive.Handlers.IAsyncHandlerInvoker, CloudDriveAPI")]
		void OnError (global::Java.Lang.Object p0, global::Java.Lang.Exception p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.handlers']/interface[@name='AsyncHandler']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='REQUEST'] and parameter[2][@type='RESULT']]"
		[Register ("onSuccess", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;Ljava/lang/Object;)V", "GetOnSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_Handler:Com.Amazon.Clouddrive.Handlers.IAsyncHandlerInvoker, CloudDriveAPI")]
		void OnSuccess (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/handlers/AsyncHandler", DoNotGenerateAcw=true)]
	internal class IAsyncHandlerInvoker : global::Java.Lang.Object, IAsyncHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/handlers/AsyncHandler");
		IntPtr class_ref;

		public static IAsyncHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.handlers.AsyncHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAsyncHandlerInvoker); }
		}

		static Delegate cb_onCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
#pragma warning disable 0169
		static Delegate GetOnCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_Handler ()
		{
			if (cb_onCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_ == null)
				cb_onCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_);
			return cb_onCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		}

		static void n_OnCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCanceled (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		public unsafe void OnCanceled (global::Java.Lang.Object p0)
		{
			if (id_onCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_ == IntPtr.Zero)
				id_onCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_ = JNIEnv.GetMethodID (class_ref, "onCanceled", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onCanceled_Lcom_amazon_clouddrive_model_CloudDriveRequest_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_ == null)
				cb_onError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_);
			return cb_onError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_;
		}

		static void n_OnError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_;
		public unsafe void OnError (global::Java.Lang.Object p0, global::Java.Lang.Exception p1)
		{
			if (id_onError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onError_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Exception_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_ == null)
				cb_onSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_);
			return cb_onSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Handlers.IAsyncHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_;
		public unsafe void OnSuccess (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_onSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_onSuccess_Lcom_amazon_clouddrive_model_CloudDriveRequest_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
