#ifndef __S2_POLYCOM_SOUNDSTRUCTURE_INPUT_BASIC_FEEDBACK_V2_1_H__
#define __S2_POLYCOM_SOUNDSTRUCTURE_INPUT_BASIC_FEEDBACK_V2_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_FADER_VALUE_IN_ANALOG_INPUT 0

#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_VIRTUAL_NAME$_STRING_INPUT 1
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_VIRTUAL_NAME$_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1, __VIRTUAL_NAME$, __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_VIRTUAL_NAME$_STRING_MAX_LEN );

#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_FROM_PROCESSOR$_BUFFER_INPUT 2
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_FROM_PROCESSOR$_BUFFER_MAX_LEN 500
CREATE_STRING_STRUCT( S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1, __FROM_PROCESSOR$, __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_FROM_PROCESSOR$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_FADER_DOWN_OK_DIG_OUTPUT 0
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_FADER_UP_OK_DIG_OUTPUT 1
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_MUTE_IN_DIG_OUTPUT 2
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_POLL_DIG_OUTPUT 3


/*
* ANALOG_OUTPUT
*/
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_FADER_IN_ANALOG_OUTPUT 0

#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_VIRTUAL_NAME_OUT$_STRING_OUTPUT 1
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_TO_DEVICE$_STRING_OUTPUT 2


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
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_SNAME_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1, __SNAME, __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_SNAME_STRING_MAX_LEN );
#define __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_SMSGFROMPROCESSOR_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1, __SMSGFROMPROCESSOR, __S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1_SMSGFROMPROCESSOR_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __ICURRENT;
   unsigned short __ISTART;
   unsigned short __IFLAG1;
   unsigned short __IPOINTER1;
   unsigned short __IPOINTER2;
   unsigned short __IVALUE;
   unsigned short __IFADERSPAN;
   unsigned short __IFADERMULTIPLIER;
   unsigned short __IFADERMOD;
   unsigned short __IFADER;
   short __SIFADERVALUEIN;
   short __SIFADER;
   short __SIMAXFADER;
   short __SIMINFADER;
   DECLARE_STRING_STRUCT( S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1, __SNAME );
   DECLARE_STRING_STRUCT( S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1, __SMSGFROMPROCESSOR );
   DECLARE_STRING_STRUCT( S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1, __VIRTUAL_NAME$ );
   DECLARE_STRING_STRUCT( S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1, __FROM_PROCESSOR$ );
};

START_NVRAM_VAR_STRUCT( S2_Polycom_SoundStructure_Input_Basic_Feedback_v2_1 )
{
};



#endif //__S2_POLYCOM_SOUNDSTRUCTURE_INPUT_BASIC_FEEDBACK_V2_1_H__

