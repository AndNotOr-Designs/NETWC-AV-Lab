#ifndef __S2_POLYCOM_SOUNDSTRUCTURE_FEEDBACK_PROCESSOR_V2_1_H__
#define __S2_POLYCOM_SOUNDSTRUCTURE_FEEDBACK_PROCESSOR_V2_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_INITIALIZE_DIG_INPUT 0
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_TIMEOUT_DIG_INPUT 1


/*
* ANALOG_INPUT
*/


#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_FROM_DEVICE$_BUFFER_INPUT 0
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_FROM_DEVICE$_BUFFER_MAX_LEN 1024
CREATE_STRING_STRUCT( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, __FROM_DEVICE$, __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_FROM_DEVICE$_BUFFER_MAX_LEN );

#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_VIRTUAL_NAME$_STRING_INPUT 1
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_VIRTUAL_NAME$_ARRAY_NUM_ELEMS 100
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_VIRTUAL_NAME$_ARRAY_NUM_CHARS 100
CREATE_STRING_ARRAY( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, __VIRTUAL_NAME$, __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_VIRTUAL_NAME$_ARRAY_NUM_ELEMS, __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_VIRTUAL_NAME$_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_TIMED_OUT_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/

#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_TO_SCRIPTS_MODULES$_STRING_OUTPUT 0

#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_TO_MODULES$_STRING_OUTPUT 1
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_TO_MODULES$_ARRAY_LENGTH 100

/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_STEMPNAME_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, __STEMPNAME, __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_STEMPNAME_STRING_MAX_LEN );
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_SCOMPORTMSG_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, __SCOMPORTMSG, __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_SCOMPORTMSG_STRING_MAX_LEN );
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_SBUFFERNAME_ARRAY_NUM_ELEMS 100
#define __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_SBUFFERNAME_ARRAY_NUM_CHARS 100
CREATE_STRING_ARRAY( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, __SBUFFERNAME, __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_SBUFFERNAME_ARRAY_NUM_ELEMS, __S2_Polycom_SoundStructure_Feedback_Processor_v2_1_SBUFFERNAME_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Polycom_SoundStructure_Feedback_Processor_v2_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __TO_MODULES$ );
   unsigned short __IFLAG1;
   unsigned short __A;
   unsigned short __B;
   unsigned short __C;
   unsigned short __INUMOUTPUTS;
   unsigned short __IPOINTER1;
   unsigned short __IPOINTER2;
   DECLARE_STRING_STRUCT( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, __STEMPNAME );
   DECLARE_STRING_STRUCT( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, __SCOMPORTMSG );
   DECLARE_STRING_ARRAY( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, __SBUFFERNAME );
   DECLARE_STRING_ARRAY( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, __VIRTUAL_NAME$ );
   DECLARE_STRING_STRUCT( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, __FROM_DEVICE$ );
};

START_NVRAM_VAR_STRUCT( S2_Polycom_SoundStructure_Feedback_Processor_v2_1 )
{
};

DEFINE_WAITEVENT( S2_Polycom_SoundStructure_Feedback_Processor_v2_1, WTIMEOUT );


#endif //__S2_POLYCOM_SOUNDSTRUCTURE_FEEDBACK_PROCESSOR_V2_1_H__

