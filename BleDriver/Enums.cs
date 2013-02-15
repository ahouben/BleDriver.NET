/*
 * Copyright (c) 2012 Alexander Houben (ahouben@greenliff.com)
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of
 * this software and associated documentation files (the "Software"), to deal in
 * the Software without restriction, including without limitation the rights to
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
 * of the Software, and to permit persons to whom the Software is furnished to do
 * so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
namespace BgApiDriver
{
    public enum ble_msg_types
    {
        ble_msg_type_cmd = 0x00,
        ble_msg_type_rsp = 0x00,
        ble_msg_type_evt = 0x80,
    };

    public enum ble_dev_types
    {
        ble_dev_type_ble = 0x00,
        ble_dev_type_wifi = 0x08,
        ble_dev_type_iwrap = 0x10,
    };

    public enum ble_error_spaces
    {
        ble_err_bt = 512,
        ble_err_att = 1024,
        ble_err_bg = 256,
        ble_err_smp = 768,
    };

    public enum ble_error
    {
        ble_err_bt_error_success = ble_error_spaces.ble_err_bt + 0,   //Command completed succesfully
        ble_err_bt_bt_error_authentication_failure = ble_error_spaces.ble_err_bt + 5,   //Pairing or authentication failed due to incorrect results in the pairing or authentication procedure. This could be due to an incorrect PIN or Link Key
        ble_err_bt_pin_or_key_missing = ble_error_spaces.ble_err_bt + 6,   //Pairing failed because of missing PIN, or authentication failed because of missing Key
        ble_err_bt_bt_error_memory_capacity_exceeded = ble_error_spaces.ble_err_bt + 7,   //Controller is out of memory.
        ble_err_bt_connection_timeout = ble_error_spaces.ble_err_bt + 8,   //Link supervision timeout has expired.
        ble_err_bt_connection_limit_exceeded = ble_error_spaces.ble_err_bt + 9,   //Controller is at limit of connections it can support.
        ble_err_bt_bt_error_command_disallowed = ble_error_spaces.ble_err_bt + 12,  //Command requested cannot be executed because the Controller is in a state where it cannot process this command at this time.
        ble_err_bt_bt_error_invalid_command_parameters = ble_error_spaces.ble_err_bt + 18,  //Command contained invalid parameters.
        ble_err_bt_bt_error_remote_user_terminated = ble_error_spaces.ble_err_bt + 19,  //User on the remote device terminated the connection.
        ble_err_bt_bt_error_connection_terminated_by_local_host = ble_error_spaces.ble_err_bt + 22,  //Local device terminated the connection.
        ble_err_bt_bt_error_ll_response_timeout = ble_error_spaces.ble_err_bt + 34,  //Connection terminated due to link-layer procedure timeout.
        ble_err_bt_bt_error_ll_instant_passed = ble_error_spaces.ble_err_bt + 40,  //Received link-layer control packet where instant was in the past.
        ble_err_bt_bt_error_controller_busy = ble_error_spaces.ble_err_bt + 58,  //Operation was rejected because the controller is busy and unable to process the request.
        ble_err_bt_bt_error_directed_advertising_timeout = ble_error_spaces.ble_err_bt + 60,  //Directed advertising completed without a connection being created.
        ble_err_bt_bt_error_connection_terminated_due_to_mic_failure = ble_error_spaces.ble_err_bt + 61,  //Connection was terminated because the Message Integrity Check (MIC) failed on a received packet.
        ble_err_bt_bt_error_connection_failed_to_be_established = ble_error_spaces.ble_err_bt + 62,  //LL initiated a connection but the connection has failed to be established. Controller did not receive any packets from remote end.
        ble_err_att_invalid_handle = ble_error_spaces.ble_err_att + 1,  //The attribute handle given was not valid on this server
        ble_err_att_read_not_permitted = ble_error_spaces.ble_err_att + 2,  //The attribute cannot be read
        ble_err_att_write_not_permitted = ble_error_spaces.ble_err_att + 3,  //The attribute cannot be written
        ble_err_att_invalid_pdu = ble_error_spaces.ble_err_att + 4,  //The attribute PDU was invalid
        ble_err_att_insufficient_authentication = ble_error_spaces.ble_err_att + 5,  //The attribute requires authentication before it can be read or written.
        ble_err_att_request_not_supported = ble_error_spaces.ble_err_att + 6,  //Attribute Server does not support the request received from the client.
        ble_err_att_invalid_offset = ble_error_spaces.ble_err_att + 7,  //Offset specified was past the end of the attribute
        ble_err_att_insufficient_authorization = ble_error_spaces.ble_err_att + 8,  //The attribute requires authorization before it can be read or written.
        ble_err_att_prepare_queue_full = ble_error_spaces.ble_err_att + 9,  //Too many prepare writes have been queueud
        ble_err_att_att_not_found = ble_error_spaces.ble_err_att + 10, //No attribute found within the given attribute handle range.
        ble_err_att_att_not_long = ble_error_spaces.ble_err_att + 11, //The attribute cannot be read or written using the Read Blob Request
        ble_err_att_insufficient_enc_key_size = ble_error_spaces.ble_err_att + 12, //The Encryption Key Size used for encrypting this link is insufficient.
        ble_err_att_invalid_att_length = ble_error_spaces.ble_err_att + 13, //The attribute value length is invalid for the operation
        ble_err_att_unlikely_error = ble_error_spaces.ble_err_att + 14, //The attribute request that was requested has encountered an error that was unlikely, and therefore could not be completed as requested.
        ble_err_att_insufficient_encryption = ble_error_spaces.ble_err_att + 15, //The attribute requires encryption before it can be read or written.
        ble_err_att_unsupported_group_type = ble_error_spaces.ble_err_att + 16, //The attribute type is not a supported grouping attribute as defined by a higher layer specification.
        ble_err_att_insufficient_resources = ble_error_spaces.ble_err_att + 17, //Insufficient Resources to complete the request
        ble_err_att_application = ble_error_spaces.ble_err_att + 128,//Application error code defined by a higher layer specification.
        ble_err_success = 0,              //No error
        ble_err_invalid_param = ble_error_spaces.ble_err_bg + 128, //Command contained invalid parameter
        ble_err_wrong_state = ble_error_spaces.ble_err_bg + 129, //Device is in wrong state to receive command
        ble_err_out_of_memory = ble_error_spaces.ble_err_bg + 130, //Device has run out of memory
        ble_err_not_implemented = ble_error_spaces.ble_err_bg + 131, //Feature is not implemented
        ble_err_invalid_command = ble_error_spaces.ble_err_bg + 132, //Command was not recognized
        ble_err_timeout = ble_error_spaces.ble_err_bg + 133, //Command or Procedure failed due to timeout
        ble_err_not_connected = ble_error_spaces.ble_err_bg + 134, //Connection handle passed is to command is not a valid handle
        ble_err_flow = ble_error_spaces.ble_err_bg + 135, //Command would cause either underflow or overflow error
        ble_err_user_attribute = ble_error_spaces.ble_err_bg + 136, //User attribute was accessed through API which is not supported
        ble_err_smp_passkey_entry_failed = ble_error_spaces.ble_err_smp + 1,  //The user input of passkey failed, for example, the user cancelled the operation
        ble_err_smp_oob_not_available = ble_error_spaces.ble_err_smp + 2,  //Out of Band data is not available for authentication
        ble_err_smp_authentication_requirements = ble_error_spaces.ble_err_smp + 3,  //The pairing procedure cannot be performed as authentication requirements cannot be met due to IO capabilities of one or both devices
        ble_err_smp_confirm_value_failed = ble_error_spaces.ble_err_smp + 4,  //The confirm value does not match the calculated compare value
        ble_err_smp_pairing_not_supported = ble_error_spaces.ble_err_smp + 5,  //Pairing is not supported by the device
        ble_err_smp_encryption_key_size = ble_error_spaces.ble_err_smp + 6,  //The resultant encryption key size is insufficient for the security requirements of this device
        ble_err_smp_command_not_supported = ble_error_spaces.ble_err_smp + 7,  //The SMP command received is not supported on this device
        ble_err_smp_unspecified_reason = ble_error_spaces.ble_err_smp + 8,  //Pairing failed due to an unspecified reason
        ble_err_smp_repeated_attempts = ble_error_spaces.ble_err_smp + 9,  //Pairing or authentication procedure is disallowed because too little time has elapsed since last pairing request or security request
        ble_err_smp_invalid_parameters = ble_error_spaces.ble_err_smp + 10, //The Invalid Parameters error code indicates: the command length is invalid or a parameter is outside of the specified range.
        ble_err_last
    };
}
