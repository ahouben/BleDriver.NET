/*
 * Copyright (c) 2012-2015 Alexander Houben (ahouben@greenliff.com)
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
// Auto-generated, do not modify
using System;

namespace BgApiDriver {
    public partial class BgApi {

        public enum ble_classes
        {
            ble_cls_system,
            ble_cls_flash,
            ble_cls_attributes,
            ble_cls_connection,
            ble_cls_attclient,
            ble_cls_sm,
            ble_cls_gap,
            ble_cls_hardware,
            ble_cls_test,
            ble_cls_dfu,
        }

        public enum ble_command_ids
        {
            ble_cmd_system_reset_id = 0,
            ble_cmd_system_hello_id = 1,
            ble_cmd_system_address_get_id = 2,
            ble_cmd_system_reg_write_id = 3,
            ble_cmd_system_reg_read_id = 4,
            ble_cmd_system_get_counters_id = 5,
            ble_cmd_system_get_connections_id = 6,
            ble_cmd_system_read_memory_id = 7,
            ble_cmd_system_get_info_id = 8,
            ble_cmd_system_endpoint_tx_id = 9,
            ble_cmd_system_whitelist_append_id = 10,
            ble_cmd_system_whitelist_remove_id = 11,
            ble_cmd_system_whitelist_clear_id = 12,
            ble_cmd_system_endpoint_rx_id = 13,
            ble_cmd_system_endpoint_set_watermarks_id = 14,
            ble_cmd_system_aes_setkey_id = 15,
            ble_cmd_system_aes_encrypt_id = 16,
            ble_cmd_system_aes_decrypt_id = 17,
            ble_cmd_flash_ps_defrag_id = 0,
            ble_cmd_flash_ps_dump_id = 1,
            ble_cmd_flash_ps_erase_all_id = 2,
            ble_cmd_flash_ps_save_id = 3,
            ble_cmd_flash_ps_load_id = 4,
            ble_cmd_flash_ps_erase_id = 5,
            ble_cmd_flash_erase_page_id = 6,
            ble_cmd_flash_write_data_id = 7,
            ble_cmd_flash_read_data_id = 8,
            ble_cmd_attributes_write_id = 0,
            ble_cmd_attributes_read_id = 1,
            ble_cmd_attributes_read_type_id = 2,
            ble_cmd_attributes_user_read_response_id = 3,
            ble_cmd_attributes_user_write_response_id = 4,
            ble_cmd_attributes_send_id = 5,
            ble_cmd_connection_disconnect_id = 0,
            ble_cmd_connection_get_rssi_id = 1,
            ble_cmd_connection_update_id = 2,
            ble_cmd_connection_version_update_id = 3,
            ble_cmd_connection_channel_map_get_id = 4,
            ble_cmd_connection_channel_map_set_id = 5,
            ble_cmd_connection_features_get_id = 6,
            ble_cmd_connection_get_status_id = 7,
            ble_cmd_connection_raw_tx_id = 8,
            ble_cmd_connection_slave_latency_disable_id = 9,
            ble_cmd_attclient_find_by_type_value_id = 0,
            ble_cmd_attclient_read_by_group_type_id = 1,
            ble_cmd_attclient_read_by_type_id = 2,
            ble_cmd_attclient_find_information_id = 3,
            ble_cmd_attclient_read_by_handle_id = 4,
            ble_cmd_attclient_attribute_write_id = 5,
            ble_cmd_attclient_write_command_id = 6,
            ble_cmd_attclient_indicate_confirm_id = 7,
            ble_cmd_attclient_read_long_id = 8,
            ble_cmd_attclient_prepare_write_id = 9,
            ble_cmd_attclient_execute_write_id = 10,
            ble_cmd_attclient_read_multiple_id = 11,
            ble_cmd_sm_encrypt_start_id = 0,
            ble_cmd_sm_set_bondable_mode_id = 1,
            ble_cmd_sm_delete_bonding_id = 2,
            ble_cmd_sm_set_parameters_id = 3,
            ble_cmd_sm_passkey_entry_id = 4,
            ble_cmd_sm_get_bonds_id = 5,
            ble_cmd_sm_set_oob_data_id = 6,
            ble_cmd_sm_whitelist_bonds_id = 7,
            ble_cmd_gap_set_privacy_flags_id = 0,
            ble_cmd_gap_set_mode_id = 1,
            ble_cmd_gap_discover_id = 2,
            ble_cmd_gap_connect_direct_id = 3,
            ble_cmd_gap_end_procedure_id = 4,
            ble_cmd_gap_connect_selective_id = 5,
            ble_cmd_gap_set_filtering_id = 6,
            ble_cmd_gap_set_scan_parameters_id = 7,
            ble_cmd_gap_set_adv_parameters_id = 8,
            ble_cmd_gap_set_adv_data_id = 9,
            ble_cmd_gap_set_directed_connectable_mode_id = 10,
            ble_cmd_gap_set_initiating_con_parameters_id = 11,
            ble_cmd_hardware_io_port_config_irq_id = 0,
            ble_cmd_hardware_set_soft_timer_id = 1,
            ble_cmd_hardware_adc_read_id = 2,
            ble_cmd_hardware_io_port_config_direction_id = 3,
            ble_cmd_hardware_io_port_config_function_id = 4,
            ble_cmd_hardware_io_port_config_pull_id = 5,
            ble_cmd_hardware_io_port_write_id = 6,
            ble_cmd_hardware_io_port_read_id = 7,
            ble_cmd_hardware_spi_config_id = 8,
            ble_cmd_hardware_spi_transfer_id = 9,
            ble_cmd_hardware_i2c_read_id = 10,
            ble_cmd_hardware_i2c_write_id = 11,
            ble_cmd_hardware_set_txpower_id = 12,
            ble_cmd_hardware_timer_comparator_id = 13,
            ble_cmd_hardware_io_port_irq_enable_id = 14,
            ble_cmd_hardware_io_port_irq_direction_id = 15,
            ble_cmd_hardware_analog_comparator_enable_id = 16,
            ble_cmd_hardware_analog_comparator_read_id = 17,
            ble_cmd_hardware_analog_comparator_config_irq_id = 18,
            ble_cmd_hardware_set_rxgain_id = 19,
            ble_cmd_hardware_usb_enable_id = 20,
            ble_cmd_test_phy_tx_id = 0,
            ble_cmd_test_phy_rx_id = 1,
            ble_cmd_test_phy_end_id = 2,
            ble_cmd_test_phy_reset_id = 3,
            ble_cmd_test_get_channel_map_id = 4,
            ble_cmd_test_debug_id = 5,
            ble_cmd_test_channel_mode_id = 6,
            ble_cmd_dfu_reset_id = 0,
            ble_cmd_dfu_flash_set_address_id = 1,
            ble_cmd_dfu_flash_upload_id = 2,
            ble_cmd_dfu_flash_upload_finish_id = 3,
        }

        public enum ble_event_ids
        {
            ble_evt_system_boot_id = 0,
            ble_evt_system_debug_id = 1,
            ble_evt_system_endpoint_watermark_rx_id = 2,
            ble_evt_system_endpoint_watermark_tx_id = 3,
            ble_evt_system_script_failure_id = 4,
            ble_evt_system_no_license_key_id = 5,
            ble_evt_system_protocol_error_id = 6,
            ble_evt_flash_ps_key_id = 0,
            ble_evt_attributes_value_id = 0,
            ble_evt_attributes_user_read_request_id = 1,
            ble_evt_attributes_status_id = 2,
            ble_evt_connection_status_id = 0,
            ble_evt_connection_version_ind_id = 1,
            ble_evt_connection_feature_ind_id = 2,
            ble_evt_connection_raw_rx_id = 3,
            ble_evt_connection_disconnected_id = 4,
            ble_evt_attclient_indicated_id = 0,
            ble_evt_attclient_procedure_completed_id = 1,
            ble_evt_attclient_group_found_id = 2,
            ble_evt_attclient_attribute_found_id = 3,
            ble_evt_attclient_find_information_found_id = 4,
            ble_evt_attclient_attribute_value_id = 5,
            ble_evt_attclient_read_multiple_response_id = 6,
            ble_evt_sm_smp_data_id = 0,
            ble_evt_sm_bonding_fail_id = 1,
            ble_evt_sm_passkey_display_id = 2,
            ble_evt_sm_passkey_request_id = 3,
            ble_evt_sm_bond_status_id = 4,
            ble_evt_gap_scan_response_id = 0,
            ble_evt_gap_mode_changed_id = 1,
            ble_evt_hardware_io_port_status_id = 0,
            ble_evt_hardware_soft_timer_id = 1,
            ble_evt_hardware_adc_result_id = 2,
            ble_evt_hardware_analog_comparator_status_id = 3,
            ble_evt_dfu_boot_id = 0,
        }

        public enum system_endpoints
        {
            system_endpoint_api = 0,
            system_endpoint_test = 1,
            system_endpoint_script = 2,
            system_endpoint_usb = 3,
            system_endpoint_uart0 = 4,
            system_endpoint_uart1 = 5,
        }

        public enum attributes_attribute_change_reason
        {
            attributes_attribute_change_reason_write_request = 0,
            attributes_attribute_change_reason_write_command = 1,
            attributes_attribute_change_reason_write_request_user = 2,
        }

        public enum attributes_attribute_status_flag
        {
            attributes_attribute_status_flag_notify = 1,
            attributes_attribute_status_flag_indicate = 2,
        }

        public enum connection_connstatus
        {
            connection_connected = 1,
            connection_encrypted = 2,
            connection_completed = 4,
            connection_parameters_change = 8,
        }

        public enum attclient_attribute_value_types
        {
            attclient_attribute_value_type_read = 0,
            attclient_attribute_value_type_notify = 1,
            attclient_attribute_value_type_indicate = 2,
            attclient_attribute_value_type_read_by_type = 3,
            attclient_attribute_value_type_read_blob = 4,
            attclient_attribute_value_type_indicate_rsp_req = 5,
        }

        public enum sm_bonding_key
        {
            sm_bonding_key_ltk = 0x01,
            sm_bonding_key_addr_public = 0x02,
            sm_bonding_key_addr_static = 0x04,
            sm_bonding_key_irk = 0x08,
            sm_bonding_key_edivrand = 0x10,
            sm_bonding_key_csrk = 0x20,
            sm_bonding_key_masterid = 0x40,
        }

        public enum sm_io_capability
        {
            sm_io_capability_displayonly = 0,
            sm_io_capability_displayyesno = 1,
            sm_io_capability_keyboardonly = 2,
            sm_io_capability_noinputnooutput = 3,
            sm_io_capability_keyboarddisplay = 4,
        }

        public enum gap_address_type
        {
            gap_address_type_public = 0,
            gap_address_type_random = 1,
        }

        public enum gap_discoverable_mode
        {
            gap_non_discoverable = 0,
            gap_limited_discoverable = 1,
            gap_general_discoverable = 2,
            gap_broadcast = 3,
            gap_user_data = 4,
        }

        public enum gap_connectable_mode
        {
            gap_non_connectable = 0,
            gap_directed_connectable = 1,
            gap_undirected_connectable = 2,
            gap_scannable_non_connectable = 3,
        }

        public enum gap_discover_mode
        {
            gap_discover_limited = 0,
            gap_discover_generic = 1,
            gap_discover_observation = 2,
        }

        public enum gap_ad_types
        {
            gap_ad_type_none = 0,
            gap_ad_type_flags = 1,
            gap_ad_type_services_16bit_more = 2,
            gap_ad_type_services_16bit_all = 3,
            gap_ad_type_services_32bit_more = 4,
            gap_ad_type_services_32bit_all = 5,
            gap_ad_type_services_128bit_more = 6,
            gap_ad_type_services_128bit_all = 7,
            gap_ad_type_localname_short = 8,
            gap_ad_type_localname_complete = 9,
            gap_ad_type_txpower = 10,
        }

        public enum gap_advertising_policy
        {
            gap_adv_policy_all = 0,
            gap_adv_policy_whitelist_scan = 1,
            gap_adv_policy_whitelist_connect = 2,
            gap_adv_policy_whitelist_all = 3,
        }

        public enum gap_scan_policy
        {
            gap_scan_policy_all = 0,
            gap_scan_policy_whitelist = 1,
        }

        // define gap_scan_header_flags
        // define gap_AD_FLAGS

        public class ble_msg_system_reset_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_system_hello_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_system_address_get_rsp_t : BgApiResponse
        {
            public bd_addr address;
        }

        public class ble_msg_system_reg_write_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_system_reg_read_rsp_t : BgApiResponse
        {
            public int address;
            public int value;
        }

        public class ble_msg_system_get_counters_rsp_t : BgApiResponse
        {
            public int txok;
            public int txretry;
            public int rxok;
            public int rxfail;
            public int mbuf;
        }

        public class ble_msg_system_get_connections_rsp_t : BgApiResponse
        {
            public int maxconn;
        }

        public class ble_msg_system_read_memory_rsp_t : BgApiResponse
        {
            public long address;
            public byte[] data;
        }

        public class ble_msg_system_get_info_rsp_t : BgApiResponse
        {
            public int major;
            public int minor;
            public int patch;
            public int build;
            public int ll_version;
            public int protocol_version;
            public int hw;
        }

        public class ble_msg_system_endpoint_tx_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_system_whitelist_append_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_system_whitelist_remove_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_system_whitelist_clear_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_system_endpoint_rx_rsp_t : BgApiResponse
        {
            //public int result;
            public byte[] data;
        }

        public class ble_msg_system_endpoint_set_watermarks_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_system_aes_setkey_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_system_aes_encrypt_rsp_t : BgApiResponse
        {
            public byte[] data;
        }

        public class ble_msg_system_aes_decrypt_rsp_t : BgApiResponse
        {
            public byte[] data;
        }

        public class ble_msg_flash_ps_defrag_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_flash_ps_dump_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_flash_ps_erase_all_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_flash_ps_save_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_flash_ps_load_rsp_t : BgApiResponse
        {
            //public int result;
            public byte[] value;
        }

        public class ble_msg_flash_ps_erase_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_flash_erase_page_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_flash_write_data_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_flash_read_data_rsp_t : BgApiResponse
        {
            public byte[] data;
        }

        public class ble_msg_attributes_write_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_attributes_read_rsp_t : BgApiResponse
        {
            public int handle;
            public int offset;
            //public int result;
            public byte[] value;
        }

        public class ble_msg_attributes_read_type_rsp_t : BgApiResponse
        {
            public int handle;
            //public int result;
            public byte[] value;
        }

        public class ble_msg_attributes_user_read_response_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_attributes_user_write_response_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_attributes_send_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_connection_disconnect_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_connection_get_rssi_rsp_t : BgApiResponse
        {
            public int connection;
            public int rssi;
        }

        public class ble_msg_connection_update_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_connection_version_update_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_connection_channel_map_get_rsp_t : BgApiResponse
        {
            public int connection;
            public byte[] map;
        }

        public class ble_msg_connection_channel_map_set_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_connection_features_get_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_connection_get_status_rsp_t : BgApiResponse
        {
            public int connection;
        }

        public class ble_msg_connection_raw_tx_rsp_t : BgApiResponse
        {
            public int connection;
        }

        public class ble_msg_connection_slave_latency_disable_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_attclient_find_by_type_value_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_attclient_read_by_group_type_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_attclient_read_by_type_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_attclient_find_information_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_attclient_read_by_handle_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_attclient_attribute_write_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_attclient_write_command_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_attclient_indicate_confirm_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_attclient_read_long_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_attclient_prepare_write_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_attclient_execute_write_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_attclient_read_multiple_rsp_t : BgApiResponse
        {
            public int connection;
            //public int result;
        }

        public class ble_msg_sm_encrypt_start_rsp_t : BgApiResponse
        {
            public int handle;
            //public int result;
        }

        public class ble_msg_sm_set_bondable_mode_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_sm_delete_bonding_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_sm_set_parameters_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_sm_passkey_entry_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_sm_get_bonds_rsp_t : BgApiResponse
        {
            public int bonds;
        }

        public class ble_msg_sm_set_oob_data_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_sm_whitelist_bonds_rsp_t : BgApiResponse
        {
            //public int result;
            public int count;
        }

        public class ble_msg_gap_set_privacy_flags_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_gap_set_mode_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_gap_discover_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_gap_connect_direct_rsp_t : BgApiResponse
        {
            //public int result;
            public int connection_handle;
        }

        public class ble_msg_gap_end_procedure_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_gap_connect_selective_rsp_t : BgApiResponse
        {
            //public int result;
            public int connection_handle;
        }

        public class ble_msg_gap_set_filtering_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_gap_set_scan_parameters_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_gap_set_adv_parameters_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_gap_set_adv_data_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_gap_set_directed_connectable_mode_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_gap_set_initiating_con_parameters_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_io_port_config_irq_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_set_soft_timer_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_adc_read_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_io_port_config_direction_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_io_port_config_function_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_io_port_config_pull_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_io_port_write_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_io_port_read_rsp_t : BgApiResponse
        {
            //public int result;
            public int port;
            public int data;
        }

        public class ble_msg_hardware_spi_config_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_spi_transfer_rsp_t : BgApiResponse
        {
            //public int result;
            public int channel;
            public byte[] data;
        }

        public class ble_msg_hardware_i2c_read_rsp_t : BgApiResponse
        {
            //public int result;
            public byte[] data;
        }

        public class ble_msg_hardware_i2c_write_rsp_t : BgApiResponse
        {
            public int written;
        }

        public class ble_msg_hardware_set_txpower_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_hardware_timer_comparator_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_io_port_irq_enable_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_io_port_irq_direction_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_analog_comparator_enable_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_hardware_analog_comparator_read_rsp_t : BgApiResponse
        {
            //public int result;
            public int output;
        }

        public class ble_msg_hardware_analog_comparator_config_irq_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_hardware_set_rxgain_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_hardware_usb_enable_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_test_phy_tx_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_test_phy_rx_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_test_phy_end_rsp_t : BgApiResponse
        {
            public int counter;
        }

        public class ble_msg_test_phy_reset_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_test_get_channel_map_rsp_t : BgApiResponse
        {
            public byte[] channel_map;
        }

        public class ble_msg_test_debug_rsp_t : BgApiResponse
        {
            public int opcode;
            public byte[] output;
        }

        public class ble_msg_test_channel_mode_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_dfu_reset_rsp_t : BgApiResponse
        {
        }

        public class ble_msg_dfu_flash_set_address_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_dfu_flash_upload_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public class ble_msg_dfu_flash_upload_finish_rsp_t : BgApiResponse
        {
            //public int result;
        }

        public void ble_cmd_system_reset(int boot_in_dfu)
        {
            log("ble_cmd_system_reset_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_reset_id;
            // data
            _data[idx++] = (byte)boot_in_dfu;
            // send
            Send(new BgApiCommand() { Data = _data }, true);
        }

        public void ble_cmd_system_hello()
        {
            log("ble_cmd_system_hello_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_hello_id;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_system_address_get_rsp_t ble_cmd_system_address_get()
        {
            log("ble_cmd_system_address_get_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_address_get_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_address_get_rsp_t)response;
        }

        public ble_msg_system_reg_write_rsp_t ble_cmd_system_reg_write(int address, int value)
        {
            log("ble_cmd_system_reg_write_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_reg_write_id;
            // data
            _data[idx++] = (byte)address;
            _data[idx++] = (byte)(address >> 8);
            _data[idx++] = (byte)value;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_reg_write_rsp_t)response;
        }

        public ble_msg_system_reg_read_rsp_t ble_cmd_system_reg_read(int address)
        {
            log("ble_cmd_system_reg_read_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_reg_read_id;
            // data
            _data[idx++] = (byte)address;
            _data[idx++] = (byte)(address >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_reg_read_rsp_t)response;
        }

        public ble_msg_system_get_counters_rsp_t ble_cmd_system_get_counters()
        {
            log("ble_cmd_system_get_counters_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_get_counters_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_get_counters_rsp_t)response;
        }

        public ble_msg_system_get_connections_rsp_t ble_cmd_system_get_connections()
        {
            log("ble_cmd_system_get_connections_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_get_connections_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_get_connections_rsp_t)response;
        }

        public ble_msg_system_read_memory_rsp_t ble_cmd_system_read_memory(long address, int length)
        {
            log("ble_cmd_system_read_memory_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 4 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 4 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_read_memory_id;
            // data
            _data[idx++] = (byte)address;
            _data[idx++] = (byte)(address >> 8);
            _data[idx++] = (byte)(address >> 16);
            _data[idx++] = (byte)(address >> 24);
            _data[idx++] = (byte)length;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_read_memory_rsp_t)response;
        }

        public ble_msg_system_get_info_rsp_t ble_cmd_system_get_info()
        {
            log("ble_cmd_system_get_info_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_get_info_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_get_info_rsp_t)response;
        }

        public ble_msg_system_endpoint_tx_rsp_t ble_cmd_system_endpoint_tx(int endpoint, byte[] data)
        {
            log("ble_cmd_system_endpoint_tx_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_endpoint_tx_id;
            // data
            _data[idx++] = (byte)endpoint;
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_endpoint_tx_rsp_t)response;
        }

        public ble_msg_system_whitelist_append_rsp_t ble_cmd_system_whitelist_append(bd_addr address, int address_type)
        {
            log("ble_cmd_system_whitelist_append_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + address.Length + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + address.Length + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_whitelist_append_id;
            // data
            for(int i = 0; i < address.Length; i++)
            {
                _data[idx++] = address.Address[i];
            }
            _data[idx++] = (byte)address_type;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_whitelist_append_rsp_t)response;
        }

        public ble_msg_system_whitelist_remove_rsp_t ble_cmd_system_whitelist_remove(bd_addr address, int address_type)
        {
            log("ble_cmd_system_whitelist_remove_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + address.Length + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + address.Length + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_whitelist_remove_id;
            // data
            for(int i = 0; i < address.Length; i++)
            {
                _data[idx++] = address.Address[i];
            }
            _data[idx++] = (byte)address_type;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_whitelist_remove_rsp_t)response;
        }

        public void ble_cmd_system_whitelist_clear()
        {
            log("ble_cmd_system_whitelist_clear_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_whitelist_clear_id;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_system_endpoint_rx_rsp_t ble_cmd_system_endpoint_rx(int endpoint, int size)
        {
            log("ble_cmd_system_endpoint_rx_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_endpoint_rx_id;
            // data
            _data[idx++] = (byte)endpoint;
            _data[idx++] = (byte)size;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_endpoint_rx_rsp_t)response;
        }

        public ble_msg_system_endpoint_set_watermarks_rsp_t ble_cmd_system_endpoint_set_watermarks(int endpoint, int rx, int tx)
        {
            log("ble_cmd_system_endpoint_set_watermarks_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_endpoint_set_watermarks_id;
            // data
            _data[idx++] = (byte)endpoint;
            _data[idx++] = (byte)rx;
            _data[idx++] = (byte)tx;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_endpoint_set_watermarks_rsp_t)response;
        }

        public void ble_cmd_system_aes_setkey(byte[] key)
        {
            log("ble_cmd_system_aes_setkey_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + key.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + key.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_aes_setkey_id;
            // data
            _data[idx++] = (byte)(key.Length);
            for(int i = 0; i < key.Length; i++)
            {
                _data[idx++] = key[i];
            }
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_system_aes_encrypt_rsp_t ble_cmd_system_aes_encrypt(byte[] data)
        {
            log("ble_cmd_system_aes_encrypt_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_aes_encrypt_id;
            // data
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_aes_encrypt_rsp_t)response;
        }

        public ble_msg_system_aes_decrypt_rsp_t ble_cmd_system_aes_decrypt(byte[] data)
        {
            log("ble_cmd_system_aes_decrypt_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_system;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_system_aes_decrypt_id;
            // data
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_system_aes_decrypt_rsp_t)response;
        }

        public void ble_cmd_flash_ps_defrag()
        {
            log("ble_cmd_flash_ps_defrag_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_flash;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_defrag_id;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public void ble_cmd_flash_ps_dump()
        {
            log("ble_cmd_flash_ps_dump_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_flash;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_dump_id;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public void ble_cmd_flash_ps_erase_all()
        {
            log("ble_cmd_flash_ps_erase_all_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_flash;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_erase_all_id;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_flash_ps_save_rsp_t ble_cmd_flash_ps_save(int key, byte[] value)
        {
            log("ble_cmd_flash_ps_save_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2 + 1 + value.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2 + 1 + value.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_flash;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_save_id;
            // data
            _data[idx++] = (byte)key;
            _data[idx++] = (byte)(key >> 8);
            _data[idx++] = (byte)(value.Length);
            for(int i = 0; i < value.Length; i++)
            {
                _data[idx++] = value[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_flash_ps_save_rsp_t)response;
        }

        public ble_msg_flash_ps_load_rsp_t ble_cmd_flash_ps_load(int key)
        {
            log("ble_cmd_flash_ps_load_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_flash;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_load_id;
            // data
            _data[idx++] = (byte)key;
            _data[idx++] = (byte)(key >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_flash_ps_load_rsp_t)response;
        }

        public void ble_cmd_flash_ps_erase(int key)
        {
            log("ble_cmd_flash_ps_erase_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_flash;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_flash_ps_erase_id;
            // data
            _data[idx++] = (byte)key;
            _data[idx++] = (byte)(key >> 8);
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_flash_erase_page_rsp_t ble_cmd_flash_erase_page(int page)
        {
            log("ble_cmd_flash_erase_page_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_flash;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_flash_erase_page_id;
            // data
            _data[idx++] = (byte)page;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_flash_erase_page_rsp_t)response;
        }

        public ble_msg_flash_write_data_rsp_t ble_cmd_flash_write_data(long address, byte[] data)
        {
            log("ble_cmd_flash_write_data_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 4 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 4 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_flash;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_flash_write_data_id;
            // data
            _data[idx++] = (byte)address;
            _data[idx++] = (byte)(address >> 8);
            _data[idx++] = (byte)(address >> 16);
            _data[idx++] = (byte)(address >> 24);
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_flash_write_data_rsp_t)response;
        }

        public ble_msg_flash_read_data_rsp_t ble_cmd_flash_read_data(long address, int length)
        {
            log("ble_cmd_flash_read_data_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 4 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 4 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_flash;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_flash_read_data_id;
            // data
            _data[idx++] = (byte)address;
            _data[idx++] = (byte)(address >> 8);
            _data[idx++] = (byte)(address >> 16);
            _data[idx++] = (byte)(address >> 24);
            _data[idx++] = (byte)length;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_flash_read_data_rsp_t)response;
        }

        public ble_msg_attributes_write_rsp_t ble_cmd_attributes_write(int handle, int offset, byte[] value)
        {
            log("ble_cmd_attributes_write_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2 + 1 + 1 + value.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2 + 1 + 1 + value.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_attributes;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attributes_write_id;
            // data
            _data[idx++] = (byte)handle;
            _data[idx++] = (byte)(handle >> 8);
            _data[idx++] = (byte)offset;
            _data[idx++] = (byte)(value.Length);
            for(int i = 0; i < value.Length; i++)
            {
                _data[idx++] = value[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attributes_write_rsp_t)response;
        }

        public ble_msg_attributes_read_rsp_t ble_cmd_attributes_read(int handle, int offset)
        {
            log("ble_cmd_attributes_read_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_attributes;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attributes_read_id;
            // data
            _data[idx++] = (byte)handle;
            _data[idx++] = (byte)(handle >> 8);
            _data[idx++] = (byte)offset;
            _data[idx++] = (byte)(offset >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attributes_read_rsp_t)response;
        }

        public ble_msg_attributes_read_type_rsp_t ble_cmd_attributes_read_type(int handle)
        {
            log("ble_cmd_attributes_read_type_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_attributes;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attributes_read_type_id;
            // data
            _data[idx++] = (byte)handle;
            _data[idx++] = (byte)(handle >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attributes_read_type_rsp_t)response;
        }

        public void ble_cmd_attributes_user_read_response(int connection, int att_error, byte[] value)
        {
            log("ble_cmd_attributes_user_read_response_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1 + value.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1 + value.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_attributes;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attributes_user_read_response_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)att_error;
            _data[idx++] = (byte)(value.Length);
            for(int i = 0; i < value.Length; i++)
            {
                _data[idx++] = value[i];
            }
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public void ble_cmd_attributes_user_write_response(int connection, int att_error)
        {
            log("ble_cmd_attributes_user_write_response_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_attributes;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attributes_user_write_response_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)att_error;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_attributes_send_rsp_t ble_cmd_attributes_send(int connection, int handle, byte[] value)
        {
            log("ble_cmd_attributes_send_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2 + 1 + value.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2 + 1 + value.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_attributes;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attributes_send_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)handle;
            _data[idx++] = (byte)(handle >> 8);
            _data[idx++] = (byte)(value.Length);
            for(int i = 0; i < value.Length; i++)
            {
                _data[idx++] = value[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attributes_send_rsp_t)response;
        }

        public ble_msg_connection_disconnect_rsp_t ble_cmd_connection_disconnect(int connection)
        {
            log("ble_cmd_connection_disconnect_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_connection;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_connection_disconnect_id;
            // data
            _data[idx++] = (byte)connection;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_connection_disconnect_rsp_t)response;
        }

        public ble_msg_connection_get_rssi_rsp_t ble_cmd_connection_get_rssi(int connection)
        {
            log("ble_cmd_connection_get_rssi_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_connection;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_connection_get_rssi_id;
            // data
            _data[idx++] = (byte)connection;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_connection_get_rssi_rsp_t)response;
        }

        public ble_msg_connection_update_rsp_t ble_cmd_connection_update(int connection, int interval_min, int interval_max, int latency, int timeout)
        {
            log("ble_cmd_connection_update_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2 + 2 + 2 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2 + 2 + 2 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_connection;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_connection_update_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)interval_min;
            _data[idx++] = (byte)(interval_min >> 8);
            _data[idx++] = (byte)interval_max;
            _data[idx++] = (byte)(interval_max >> 8);
            _data[idx++] = (byte)latency;
            _data[idx++] = (byte)(latency >> 8);
            _data[idx++] = (byte)timeout;
            _data[idx++] = (byte)(timeout >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_connection_update_rsp_t)response;
        }

        public ble_msg_connection_version_update_rsp_t ble_cmd_connection_version_update(int connection)
        {
            log("ble_cmd_connection_version_update_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_connection;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_connection_version_update_id;
            // data
            _data[idx++] = (byte)connection;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_connection_version_update_rsp_t)response;
        }

        public ble_msg_connection_channel_map_get_rsp_t ble_cmd_connection_channel_map_get(int connection)
        {
            log("ble_cmd_connection_channel_map_get_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_connection;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_connection_channel_map_get_id;
            // data
            _data[idx++] = (byte)connection;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_connection_channel_map_get_rsp_t)response;
        }

        public ble_msg_connection_channel_map_set_rsp_t ble_cmd_connection_channel_map_set(int connection, byte[] map)
        {
            log("ble_cmd_connection_channel_map_set_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + map.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + map.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_connection;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_connection_channel_map_set_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)(map.Length);
            for(int i = 0; i < map.Length; i++)
            {
                _data[idx++] = map[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_connection_channel_map_set_rsp_t)response;
        }

        public ble_msg_connection_features_get_rsp_t ble_cmd_connection_features_get(int connection)
        {
            log("ble_cmd_connection_features_get_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_connection;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_connection_features_get_id;
            // data
            _data[idx++] = (byte)connection;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_connection_features_get_rsp_t)response;
        }

        public ble_msg_connection_get_status_rsp_t ble_cmd_connection_get_status(int connection)
        {
            log("ble_cmd_connection_get_status_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_connection;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_connection_get_status_id;
            // data
            _data[idx++] = (byte)connection;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_connection_get_status_rsp_t)response;
        }

        public ble_msg_connection_raw_tx_rsp_t ble_cmd_connection_raw_tx(int connection, byte[] data)
        {
            log("ble_cmd_connection_raw_tx_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_connection;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_connection_raw_tx_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_connection_raw_tx_rsp_t)response;
        }

        public ble_msg_connection_slave_latency_disable_rsp_t ble_cmd_connection_slave_latency_disable(int disable)
        {
            log("ble_cmd_connection_slave_latency_disable_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_connection;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_connection_slave_latency_disable_id;
            // data
            _data[idx++] = (byte)disable;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_connection_slave_latency_disable_rsp_t)response;
        }

        public ble_msg_attclient_find_by_type_value_rsp_t ble_cmd_attclient_find_by_type_value(int connection, int start, int end, int uuid, byte[] value)
        {
            log("ble_cmd_attclient_find_by_type_value_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2 + 2 + 2 + 1 + value.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2 + 2 + 2 + 1 + value.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_find_by_type_value_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)start;
            _data[idx++] = (byte)(start >> 8);
            _data[idx++] = (byte)end;
            _data[idx++] = (byte)(end >> 8);
            _data[idx++] = (byte)uuid;
            _data[idx++] = (byte)(uuid >> 8);
            _data[idx++] = (byte)(value.Length);
            for(int i = 0; i < value.Length; i++)
            {
                _data[idx++] = value[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_find_by_type_value_rsp_t)response;
        }

        public ble_msg_attclient_read_by_group_type_rsp_t ble_cmd_attclient_read_by_group_type(int connection, int start, int end, byte[] uuid)
        {
            log("ble_cmd_attclient_read_by_group_type_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2 + 2 + 1 + uuid.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2 + 2 + 1 + uuid.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_read_by_group_type_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)start;
            _data[idx++] = (byte)(start >> 8);
            _data[idx++] = (byte)end;
            _data[idx++] = (byte)(end >> 8);
            _data[idx++] = (byte)(uuid.Length);
            for(int i = 0; i < uuid.Length; i++)
            {
                _data[idx++] = uuid[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_read_by_group_type_rsp_t)response;
        }

        public ble_msg_attclient_read_by_type_rsp_t ble_cmd_attclient_read_by_type(int connection, int start, int end, byte[] uuid)
        {
            log("ble_cmd_attclient_read_by_type_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2 + 2 + 1 + uuid.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2 + 2 + 1 + uuid.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_read_by_type_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)start;
            _data[idx++] = (byte)(start >> 8);
            _data[idx++] = (byte)end;
            _data[idx++] = (byte)(end >> 8);
            _data[idx++] = (byte)(uuid.Length);
            for(int i = 0; i < uuid.Length; i++)
            {
                _data[idx++] = uuid[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_read_by_type_rsp_t)response;
        }

        public ble_msg_attclient_find_information_rsp_t ble_cmd_attclient_find_information(int connection, int start, int end)
        {
            log("ble_cmd_attclient_find_information_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_find_information_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)start;
            _data[idx++] = (byte)(start >> 8);
            _data[idx++] = (byte)end;
            _data[idx++] = (byte)(end >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_find_information_rsp_t)response;
        }

        public ble_msg_attclient_read_by_handle_rsp_t ble_cmd_attclient_read_by_handle(int connection, int chrhandle)
        {
            log("ble_cmd_attclient_read_by_handle_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_read_by_handle_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)chrhandle;
            _data[idx++] = (byte)(chrhandle >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_read_by_handle_rsp_t)response;
        }

        public ble_msg_attclient_attribute_write_rsp_t ble_cmd_attclient_attribute_write(int connection, int atthandle, byte[] data)
        {
            log("ble_cmd_attclient_attribute_write_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_attribute_write_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)atthandle;
            _data[idx++] = (byte)(atthandle >> 8);
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_attribute_write_rsp_t)response;
        }

        public ble_msg_attclient_write_command_rsp_t ble_cmd_attclient_write_command(int connection, int atthandle, byte[] data)
        {
            log("ble_cmd_attclient_write_command_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_write_command_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)atthandle;
            _data[idx++] = (byte)(atthandle >> 8);
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_write_command_rsp_t)response;
        }

        public ble_msg_attclient_indicate_confirm_rsp_t ble_cmd_attclient_indicate_confirm(int connection)
        {
            log("ble_cmd_attclient_indicate_confirm_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_indicate_confirm_id;
            // data
            _data[idx++] = (byte)connection;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_indicate_confirm_rsp_t)response;
        }

        public ble_msg_attclient_read_long_rsp_t ble_cmd_attclient_read_long(int connection, int chrhandle)
        {
            log("ble_cmd_attclient_read_long_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_read_long_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)chrhandle;
            _data[idx++] = (byte)(chrhandle >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_read_long_rsp_t)response;
        }

        public ble_msg_attclient_prepare_write_rsp_t ble_cmd_attclient_prepare_write(int connection, int atthandle, int offset, byte[] data)
        {
            log("ble_cmd_attclient_prepare_write_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 2 + 2 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 2 + 2 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_prepare_write_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)atthandle;
            _data[idx++] = (byte)(atthandle >> 8);
            _data[idx++] = (byte)offset;
            _data[idx++] = (byte)(offset >> 8);
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_prepare_write_rsp_t)response;
        }

        public ble_msg_attclient_execute_write_rsp_t ble_cmd_attclient_execute_write(int connection, int commit)
        {
            log("ble_cmd_attclient_execute_write_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_execute_write_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)commit;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_execute_write_rsp_t)response;
        }

        public ble_msg_attclient_read_multiple_rsp_t ble_cmd_attclient_read_multiple(int connection, byte[] handles)
        {
            log("ble_cmd_attclient_read_multiple_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + handles.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + handles.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_attclient;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_attclient_read_multiple_id;
            // data
            _data[idx++] = (byte)connection;
            _data[idx++] = (byte)(handles.Length);
            for(int i = 0; i < handles.Length; i++)
            {
                _data[idx++] = handles[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_attclient_read_multiple_rsp_t)response;
        }

        public ble_msg_sm_encrypt_start_rsp_t ble_cmd_sm_encrypt_start(int handle, int bonding)
        {
            log("ble_cmd_sm_encrypt_start_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_sm;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_sm_encrypt_start_id;
            // data
            _data[idx++] = (byte)handle;
            _data[idx++] = (byte)bonding;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_sm_encrypt_start_rsp_t)response;
        }

        public void ble_cmd_sm_set_bondable_mode(int bondable)
        {
            log("ble_cmd_sm_set_bondable_mode_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_sm;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_sm_set_bondable_mode_id;
            // data
            _data[idx++] = (byte)bondable;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_sm_delete_bonding_rsp_t ble_cmd_sm_delete_bonding(int handle)
        {
            log("ble_cmd_sm_delete_bonding_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_sm;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_sm_delete_bonding_id;
            // data
            _data[idx++] = (byte)handle;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_sm_delete_bonding_rsp_t)response;
        }

        public void ble_cmd_sm_set_parameters(int mitm, int min_key_size, int io_capabilities)
        {
            log("ble_cmd_sm_set_parameters_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_sm;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_sm_set_parameters_id;
            // data
            _data[idx++] = (byte)mitm;
            _data[idx++] = (byte)min_key_size;
            _data[idx++] = (byte)io_capabilities;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_sm_passkey_entry_rsp_t ble_cmd_sm_passkey_entry(int handle, long passkey)
        {
            log("ble_cmd_sm_passkey_entry_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 4];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 4);
            _data[idx++] = (byte)ble_classes.ble_cls_sm;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_sm_passkey_entry_id;
            // data
            _data[idx++] = (byte)handle;
            _data[idx++] = (byte)passkey;
            _data[idx++] = (byte)(passkey >> 8);
            _data[idx++] = (byte)(passkey >> 16);
            _data[idx++] = (byte)(passkey >> 24);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_sm_passkey_entry_rsp_t)response;
        }

        public ble_msg_sm_get_bonds_rsp_t ble_cmd_sm_get_bonds()
        {
            log("ble_cmd_sm_get_bonds_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_sm;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_sm_get_bonds_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_sm_get_bonds_rsp_t)response;
        }

        public void ble_cmd_sm_set_oob_data(byte[] oob)
        {
            log("ble_cmd_sm_set_oob_data_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + oob.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + oob.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_sm;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_sm_set_oob_data_id;
            // data
            _data[idx++] = (byte)(oob.Length);
            for(int i = 0; i < oob.Length; i++)
            {
                _data[idx++] = oob[i];
            }
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_sm_whitelist_bonds_rsp_t ble_cmd_sm_whitelist_bonds()
        {
            log("ble_cmd_sm_whitelist_bonds_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_sm;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_sm_whitelist_bonds_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_sm_whitelist_bonds_rsp_t)response;
        }

        public void ble_cmd_gap_set_privacy_flags(int peripheral_privacy, int central_privacy)
        {
            log("ble_cmd_gap_set_privacy_flags_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_privacy_flags_id;
            // data
            _data[idx++] = (byte)peripheral_privacy;
            _data[idx++] = (byte)central_privacy;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_gap_set_mode_rsp_t ble_cmd_gap_set_mode(int discover, int connect)
        {
            log("ble_cmd_gap_set_mode_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_mode_id;
            // data
            _data[idx++] = (byte)discover;
            _data[idx++] = (byte)connect;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_set_mode_rsp_t)response;
        }

        public ble_msg_gap_discover_rsp_t ble_cmd_gap_discover(int mode)
        {
            log("ble_cmd_gap_discover_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_discover_id;
            // data
            _data[idx++] = (byte)mode;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_discover_rsp_t)response;
        }

        public ble_msg_gap_connect_direct_rsp_t ble_cmd_gap_connect_direct(bd_addr address, int addr_type, int conn_interval_min, int conn_interval_max, int timeout, int latency)
        {
            log("ble_cmd_gap_connect_direct_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + address.Length + 1 + 2 + 2 + 2 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + address.Length + 1 + 2 + 2 + 2 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_connect_direct_id;
            // data
            for(int i = 0; i < address.Length; i++)
            {
                _data[idx++] = address.Address[i];
            }
            _data[idx++] = (byte)addr_type;
            _data[idx++] = (byte)conn_interval_min;
            _data[idx++] = (byte)(conn_interval_min >> 8);
            _data[idx++] = (byte)conn_interval_max;
            _data[idx++] = (byte)(conn_interval_max >> 8);
            _data[idx++] = (byte)timeout;
            _data[idx++] = (byte)(timeout >> 8);
            _data[idx++] = (byte)latency;
            _data[idx++] = (byte)(latency >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_connect_direct_rsp_t)response;
        }

        public ble_msg_gap_end_procedure_rsp_t ble_cmd_gap_end_procedure()
        {
            log("ble_cmd_gap_end_procedure_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_end_procedure_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_end_procedure_rsp_t)response;
        }

        public ble_msg_gap_connect_selective_rsp_t ble_cmd_gap_connect_selective(int conn_interval_min, int conn_interval_max, int timeout, int latency)
        {
            log("ble_cmd_gap_connect_selective_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2 + 2 + 2 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2 + 2 + 2 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_connect_selective_id;
            // data
            _data[idx++] = (byte)conn_interval_min;
            _data[idx++] = (byte)(conn_interval_min >> 8);
            _data[idx++] = (byte)conn_interval_max;
            _data[idx++] = (byte)(conn_interval_max >> 8);
            _data[idx++] = (byte)timeout;
            _data[idx++] = (byte)(timeout >> 8);
            _data[idx++] = (byte)latency;
            _data[idx++] = (byte)(latency >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_connect_selective_rsp_t)response;
        }

        public ble_msg_gap_set_filtering_rsp_t ble_cmd_gap_set_filtering(int scan_policy, int adv_policy, int scan_duplicate_filtering)
        {
            log("ble_cmd_gap_set_filtering_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_filtering_id;
            // data
            _data[idx++] = (byte)scan_policy;
            _data[idx++] = (byte)adv_policy;
            _data[idx++] = (byte)scan_duplicate_filtering;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_set_filtering_rsp_t)response;
        }

        public ble_msg_gap_set_scan_parameters_rsp_t ble_cmd_gap_set_scan_parameters(int scan_interval, int scan_window, int active)
        {
            log("ble_cmd_gap_set_scan_parameters_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2 + 2 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2 + 2 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_scan_parameters_id;
            // data
            _data[idx++] = (byte)scan_interval;
            _data[idx++] = (byte)(scan_interval >> 8);
            _data[idx++] = (byte)scan_window;
            _data[idx++] = (byte)(scan_window >> 8);
            _data[idx++] = (byte)active;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_set_scan_parameters_rsp_t)response;
        }

        public ble_msg_gap_set_adv_parameters_rsp_t ble_cmd_gap_set_adv_parameters(int adv_interval_min, int adv_interval_max, int adv_channels)
        {
            log("ble_cmd_gap_set_adv_parameters_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2 + 2 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2 + 2 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_adv_parameters_id;
            // data
            _data[idx++] = (byte)adv_interval_min;
            _data[idx++] = (byte)(adv_interval_min >> 8);
            _data[idx++] = (byte)adv_interval_max;
            _data[idx++] = (byte)(adv_interval_max >> 8);
            _data[idx++] = (byte)adv_channels;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_set_adv_parameters_rsp_t)response;
        }

        public ble_msg_gap_set_adv_data_rsp_t ble_cmd_gap_set_adv_data(int set_scanrsp, byte[] adv_data)
        {
            log("ble_cmd_gap_set_adv_data_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + adv_data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + adv_data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_adv_data_id;
            // data
            _data[idx++] = (byte)set_scanrsp;
            _data[idx++] = (byte)(adv_data.Length);
            for(int i = 0; i < adv_data.Length; i++)
            {
                _data[idx++] = adv_data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_set_adv_data_rsp_t)response;
        }

        public ble_msg_gap_set_directed_connectable_mode_rsp_t ble_cmd_gap_set_directed_connectable_mode(bd_addr address, int addr_type)
        {
            log("ble_cmd_gap_set_directed_connectable_mode_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + address.Length + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + address.Length + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_directed_connectable_mode_id;
            // data
            for(int i = 0; i < address.Length; i++)
            {
                _data[idx++] = address.Address[i];
            }
            _data[idx++] = (byte)addr_type;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_set_directed_connectable_mode_rsp_t)response;
        }

        public ble_msg_gap_set_initiating_con_parameters_rsp_t ble_cmd_gap_set_initiating_con_parameters(int scan_interval, int scan_window)
        {
            log("ble_cmd_gap_set_initiating_con_parameters_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 2 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 2 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_gap;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_gap_set_initiating_con_parameters_id;
            // data
            _data[idx++] = (byte)scan_interval;
            _data[idx++] = (byte)(scan_interval >> 8);
            _data[idx++] = (byte)scan_window;
            _data[idx++] = (byte)(scan_window >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_gap_set_initiating_con_parameters_rsp_t)response;
        }

        public ble_msg_hardware_io_port_config_irq_rsp_t ble_cmd_hardware_io_port_config_irq(int port, int enable_bits, int falling_edge)
        {
            log("ble_cmd_hardware_io_port_config_irq_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_config_irq_id;
            // data
            _data[idx++] = (byte)port;
            _data[idx++] = (byte)enable_bits;
            _data[idx++] = (byte)falling_edge;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_io_port_config_irq_rsp_t)response;
        }

        public ble_msg_hardware_set_soft_timer_rsp_t ble_cmd_hardware_set_soft_timer(long time, int handle, int single_shot)
        {
            log("ble_cmd_hardware_set_soft_timer_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 4 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 4 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_set_soft_timer_id;
            // data
            _data[idx++] = (byte)time;
            _data[idx++] = (byte)(time >> 8);
            _data[idx++] = (byte)(time >> 16);
            _data[idx++] = (byte)(time >> 24);
            _data[idx++] = (byte)handle;
            _data[idx++] = (byte)single_shot;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_set_soft_timer_rsp_t)response;
        }

        public ble_msg_hardware_adc_read_rsp_t ble_cmd_hardware_adc_read(int input, int decimation, int reference_selection)
        {
            log("ble_cmd_hardware_adc_read_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_adc_read_id;
            // data
            _data[idx++] = (byte)input;
            _data[idx++] = (byte)decimation;
            _data[idx++] = (byte)reference_selection;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_adc_read_rsp_t)response;
        }

        public ble_msg_hardware_io_port_config_direction_rsp_t ble_cmd_hardware_io_port_config_direction(int port, int direction)
        {
            log("ble_cmd_hardware_io_port_config_direction_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_config_direction_id;
            // data
            _data[idx++] = (byte)port;
            _data[idx++] = (byte)direction;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_io_port_config_direction_rsp_t)response;
        }

        public ble_msg_hardware_io_port_config_function_rsp_t ble_cmd_hardware_io_port_config_function(int port, int function)
        {
            log("ble_cmd_hardware_io_port_config_function_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_config_function_id;
            // data
            _data[idx++] = (byte)port;
            _data[idx++] = (byte)function;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_io_port_config_function_rsp_t)response;
        }

        public ble_msg_hardware_io_port_config_pull_rsp_t ble_cmd_hardware_io_port_config_pull(int port, int tristate_mask, int pull_up)
        {
            log("ble_cmd_hardware_io_port_config_pull_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_config_pull_id;
            // data
            _data[idx++] = (byte)port;
            _data[idx++] = (byte)tristate_mask;
            _data[idx++] = (byte)pull_up;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_io_port_config_pull_rsp_t)response;
        }

        public ble_msg_hardware_io_port_write_rsp_t ble_cmd_hardware_io_port_write(int port, int mask, int data)
        {
            log("ble_cmd_hardware_io_port_write_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_write_id;
            // data
            _data[idx++] = (byte)port;
            _data[idx++] = (byte)mask;
            _data[idx++] = (byte)data;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_io_port_write_rsp_t)response;
        }

        public ble_msg_hardware_io_port_read_rsp_t ble_cmd_hardware_io_port_read(int port, int mask)
        {
            log("ble_cmd_hardware_io_port_read_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_read_id;
            // data
            _data[idx++] = (byte)port;
            _data[idx++] = (byte)mask;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_io_port_read_rsp_t)response;
        }

        public ble_msg_hardware_spi_config_rsp_t ble_cmd_hardware_spi_config(int channel, int polarity, int phase, int bit_order, int baud_e, int baud_m)
        {
            log("ble_cmd_hardware_spi_config_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1 + 1 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1 + 1 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_spi_config_id;
            // data
            _data[idx++] = (byte)channel;
            _data[idx++] = (byte)polarity;
            _data[idx++] = (byte)phase;
            _data[idx++] = (byte)bit_order;
            _data[idx++] = (byte)baud_e;
            _data[idx++] = (byte)baud_m;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_spi_config_rsp_t)response;
        }

        public ble_msg_hardware_spi_transfer_rsp_t ble_cmd_hardware_spi_transfer(int channel, byte[] data)
        {
            log("ble_cmd_hardware_spi_transfer_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_spi_transfer_id;
            // data
            _data[idx++] = (byte)channel;
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_spi_transfer_rsp_t)response;
        }

        public ble_msg_hardware_i2c_read_rsp_t ble_cmd_hardware_i2c_read(int address, int stop, int length)
        {
            log("ble_cmd_hardware_i2c_read_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_i2c_read_id;
            // data
            _data[idx++] = (byte)address;
            _data[idx++] = (byte)stop;
            _data[idx++] = (byte)length;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_i2c_read_rsp_t)response;
        }

        public ble_msg_hardware_i2c_write_rsp_t ble_cmd_hardware_i2c_write(int address, int stop, byte[] data)
        {
            log("ble_cmd_hardware_i2c_write_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_i2c_write_id;
            // data
            _data[idx++] = (byte)address;
            _data[idx++] = (byte)stop;
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_i2c_write_rsp_t)response;
        }

        public void ble_cmd_hardware_set_txpower(int power)
        {
            log("ble_cmd_hardware_set_txpower_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_set_txpower_id;
            // data
            _data[idx++] = (byte)power;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_hardware_timer_comparator_rsp_t ble_cmd_hardware_timer_comparator(int timer, int channel, int mode, int comparator_value)
        {
            log("ble_cmd_hardware_timer_comparator_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1 + 2];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1 + 2);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_timer_comparator_id;
            // data
            _data[idx++] = (byte)timer;
            _data[idx++] = (byte)channel;
            _data[idx++] = (byte)mode;
            _data[idx++] = (byte)comparator_value;
            _data[idx++] = (byte)(comparator_value >> 8);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_timer_comparator_rsp_t)response;
        }

        public ble_msg_hardware_io_port_irq_enable_rsp_t ble_cmd_hardware_io_port_irq_enable(int port, int enable_bits)
        {
            log("ble_cmd_hardware_io_port_irq_enable_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_irq_enable_id;
            // data
            _data[idx++] = (byte)port;
            _data[idx++] = (byte)enable_bits;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_io_port_irq_enable_rsp_t)response;
        }

        public ble_msg_hardware_io_port_irq_direction_rsp_t ble_cmd_hardware_io_port_irq_direction(int port, int falling_edge)
        {
            log("ble_cmd_hardware_io_port_irq_direction_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_io_port_irq_direction_id;
            // data
            _data[idx++] = (byte)port;
            _data[idx++] = (byte)falling_edge;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_io_port_irq_direction_rsp_t)response;
        }

        public void ble_cmd_hardware_analog_comparator_enable(int enable)
        {
            log("ble_cmd_hardware_analog_comparator_enable_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_analog_comparator_enable_id;
            // data
            _data[idx++] = (byte)enable;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_hardware_analog_comparator_read_rsp_t ble_cmd_hardware_analog_comparator_read()
        {
            log("ble_cmd_hardware_analog_comparator_read_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_analog_comparator_read_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_analog_comparator_read_rsp_t)response;
        }

        public ble_msg_hardware_analog_comparator_config_irq_rsp_t ble_cmd_hardware_analog_comparator_config_irq(int enabled)
        {
            log("ble_cmd_hardware_analog_comparator_config_irq_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_analog_comparator_config_irq_id;
            // data
            _data[idx++] = (byte)enabled;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_analog_comparator_config_irq_rsp_t)response;
        }

        public void ble_cmd_hardware_set_rxgain(int gain)
        {
            log("ble_cmd_hardware_set_rxgain_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_set_rxgain_id;
            // data
            _data[idx++] = (byte)gain;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_hardware_usb_enable_rsp_t ble_cmd_hardware_usb_enable(int enable)
        {
            log("ble_cmd_hardware_usb_enable_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_hardware;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_hardware_usb_enable_id;
            // data
            _data[idx++] = (byte)enable;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_hardware_usb_enable_rsp_t)response;
        }

        public void ble_cmd_test_phy_tx(int channel, int length, int type)
        {
            log("ble_cmd_test_phy_tx_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_test;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_test_phy_tx_id;
            // data
            _data[idx++] = (byte)channel;
            _data[idx++] = (byte)length;
            _data[idx++] = (byte)type;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public void ble_cmd_test_phy_rx(int channel)
        {
            log("ble_cmd_test_phy_rx_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_test;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_test_phy_rx_id;
            // data
            _data[idx++] = (byte)channel;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_test_phy_end_rsp_t ble_cmd_test_phy_end()
        {
            log("ble_cmd_test_phy_end_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_test;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_test_phy_end_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_test_phy_end_rsp_t)response;
        }

        public void ble_cmd_test_phy_reset()
        {
            log("ble_cmd_test_phy_reset_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_test;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_test_phy_reset_id;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public ble_msg_test_get_channel_map_rsp_t ble_cmd_test_get_channel_map()
        {
            log("ble_cmd_test_get_channel_map_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_test;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_test_get_channel_map_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_test_get_channel_map_rsp_t)response;
        }

        public ble_msg_test_debug_rsp_t ble_cmd_test_debug(int opcode, byte[] input)
        {
            log("ble_cmd_test_debug_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + 1 + input.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + 1 + input.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_test;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_test_debug_id;
            // data
            _data[idx++] = (byte)opcode;
            _data[idx++] = (byte)(input.Length);
            for(int i = 0; i < input.Length; i++)
            {
                _data[idx++] = input[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_test_debug_rsp_t)response;
        }

        public void ble_cmd_test_channel_mode(int mode)
        {
            log("ble_cmd_test_channel_mode_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_test;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_test_channel_mode_id;
            // data
            _data[idx++] = (byte)mode;
            // send
            Send(new BgApiCommand() { Data = _data }, false);
        }

        public void ble_cmd_dfu_reset(int dfu)
        {
            log("ble_cmd_dfu_reset_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1);
            _data[idx++] = (byte)ble_classes.ble_cls_dfu;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_dfu_reset_id;
            // data
            _data[idx++] = (byte)dfu;
            // send
            Send(new BgApiCommand() { Data = _data }, true);
        }

        public ble_msg_dfu_flash_set_address_rsp_t ble_cmd_dfu_flash_set_address(long address)
        {
            log("ble_cmd_dfu_flash_set_address_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 4];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 4);
            _data[idx++] = (byte)ble_classes.ble_cls_dfu;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_dfu_flash_set_address_id;
            // data
            _data[idx++] = (byte)address;
            _data[idx++] = (byte)(address >> 8);
            _data[idx++] = (byte)(address >> 16);
            _data[idx++] = (byte)(address >> 24);
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_dfu_flash_set_address_rsp_t)response;
        }

        public ble_msg_dfu_flash_upload_rsp_t ble_cmd_dfu_flash_upload(byte[] data)
        {
            log("ble_cmd_dfu_flash_upload_id");
            byte[] _data = new byte[SIZE_HEADER + 0 + 1 + data.Length];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0 + 1 + data.Length);
            _data[idx++] = (byte)ble_classes.ble_cls_dfu;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_dfu_flash_upload_id;
            // data
            _data[idx++] = (byte)(data.Length);
            for(int i = 0; i < data.Length; i++)
            {
                _data[idx++] = data[i];
            }
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_dfu_flash_upload_rsp_t)response;
        }

        public ble_msg_dfu_flash_upload_finish_rsp_t ble_cmd_dfu_flash_upload_finish()
        {
            log("ble_cmd_dfu_flash_upload_finish_id");
            byte[] _data = new byte[SIZE_HEADER + 0];
            int idx = 0;
            // header
            _data[idx++] = (byte)ble_dev_types.ble_dev_type_ble|(byte)ble_msg_types.ble_msg_type_cmd|0x0;
            _data[idx++] = (byte)(0);
            _data[idx++] = (byte)ble_classes.ble_cls_dfu;
            _data[idx++] = (byte)ble_command_ids.ble_cmd_dfu_flash_upload_finish_id;
            // send
            BgApiResponse response = Send(new BgApiCommand() { Data = _data }, false);
            return (ble_msg_dfu_flash_upload_finish_rsp_t)response;
        }

        public class ble_msg_system_boot_evt_t : BgApiEvent
        {
            public int major;
            public int minor;
            public int patch;
            public int build;
            public int ll_version;
            public int protocol_version;
            public int hw;
        }

        public class ble_msg_system_debug_evt_t : BgApiEvent
        {
            public byte[] data;
        }

        public class ble_msg_system_endpoint_watermark_rx_evt_t : BgApiEvent
        {
            public int endpoint;
            public int data;
        }

        public class ble_msg_system_endpoint_watermark_tx_evt_t : BgApiEvent
        {
            public int endpoint;
            public int data;
        }

        public class ble_msg_system_script_failure_evt_t : BgApiEvent
        {
            public int address;
            public int reason;
        }

        public class ble_msg_system_no_license_key_evt_t : BgApiEvent
        {
        }

        public class ble_msg_system_protocol_error_evt_t : BgApiEvent
        {
            public int reason;
        }

        public class ble_msg_flash_ps_key_evt_t : BgApiEvent
        {
            public int key;
            public byte[] value;
        }

        public class ble_msg_attributes_value_evt_t : BgApiEvent
        {
            public int connection;
            public int reason;
            public int handle;
            public int offset;
            public byte[] value;
        }

        public class ble_msg_attributes_user_read_request_evt_t : BgApiEvent
        {
            public int connection;
            public int handle;
            public int offset;
            public int maxsize;
        }

        public class ble_msg_attributes_status_evt_t : BgApiEvent
        {
            public int handle;
            public int flags;
        }

        public class ble_msg_connection_status_evt_t : BgApiEvent
        {
            public int connection;
            public int flags;
            public bd_addr address;
            public int address_type;
            public int conn_interval;
            public int timeout;
            public int latency;
            public int bonding;
        }

        public class ble_msg_connection_version_ind_evt_t : BgApiEvent
        {
            public int connection;
            public int vers_nr;
            public int comp_id;
            public int sub_vers_nr;
        }

        public class ble_msg_connection_feature_ind_evt_t : BgApiEvent
        {
            public int connection;
            public byte[] features;
        }

        public class ble_msg_connection_raw_rx_evt_t : BgApiEvent
        {
            public int connection;
            public byte[] data;
        }

        public class ble_msg_connection_disconnected_evt_t : BgApiEvent
        {
            public int connection;
            public int reason;
        }

        public class ble_msg_attclient_indicated_evt_t : BgApiEvent
        {
            public int connection;
            public int attrhandle;
        }

        public class ble_msg_attclient_procedure_completed_evt_t : BgApiEvent
        {
            public int connection;
            //public int result;
            public int chrhandle;
        }

        public class ble_msg_attclient_group_found_evt_t : BgApiEvent
        {
            public int connection;
            public int start;
            public int end;
            public byte[] uuid;
        }

        public class ble_msg_attclient_attribute_found_evt_t : BgApiEvent
        {
            public int connection;
            public int chrdecl;
            public int value;
            public int properties;
            public byte[] uuid;
        }

        public class ble_msg_attclient_find_information_found_evt_t : BgApiEvent
        {
            public int connection;
            public int chrhandle;
            public byte[] uuid;
        }

        public class ble_msg_attclient_attribute_value_evt_t : BgApiEvent
        {
            public int connection;
            public int atthandle;
            public int type;
            public byte[] value;
        }

        public class ble_msg_attclient_read_multiple_response_evt_t : BgApiEvent
        {
            public int connection;
            public byte[] handles;
        }

        public class ble_msg_sm_smp_data_evt_t : BgApiEvent
        {
            public int handle;
            public int packet;
            public byte[] data;
        }

        public class ble_msg_sm_bonding_fail_evt_t : BgApiEvent
        {
            public int handle;
            //public int result;
        }

        public class ble_msg_sm_passkey_display_evt_t : BgApiEvent
        {
            public int handle;
            public long passkey;
        }

        public class ble_msg_sm_passkey_request_evt_t : BgApiEvent
        {
            public int handle;
        }

        public class ble_msg_sm_bond_status_evt_t : BgApiEvent
        {
            public int bond;
            public int keysize;
            public int mitm;
            public int keys;
        }

        public class ble_msg_gap_scan_response_evt_t : BgApiEvent
        {
            public int rssi;
            public int packet_type;
            public bd_addr sender;
            public int address_type;
            public int bond;
            public byte[] data;
        }

        public class ble_msg_gap_mode_changed_evt_t : BgApiEvent
        {
            public int discover;
            public int connect;
        }

        public class ble_msg_hardware_io_port_status_evt_t : BgApiEvent
        {
            public long timestamp;
            public int port;
            public int irq;
            public int state;
        }

        public class ble_msg_hardware_soft_timer_evt_t : BgApiEvent
        {
            public int handle;
        }

        public class ble_msg_hardware_adc_result_evt_t : BgApiEvent
        {
            public int input;
            public int value;
        }

        public class ble_msg_hardware_analog_comparator_status_evt_t : BgApiEvent
        {
            public long timestamp;
            public int output;
        }

        public class ble_msg_dfu_boot_evt_t : BgApiEvent
        {
            public long version;
        }

        protected virtual void ble_evt_system_boot(ble_msg_system_boot_evt_t arg)
        {
            log("ble_evt_system_boot");
        }

        protected virtual void ble_evt_system_debug(ble_msg_system_debug_evt_t arg)
        {
            log("ble_evt_system_debug");
        }

        protected virtual void ble_evt_system_endpoint_watermark_rx(ble_msg_system_endpoint_watermark_rx_evt_t arg)
        {
            log("ble_evt_system_endpoint_watermark_rx");
        }

        protected virtual void ble_evt_system_endpoint_watermark_tx(ble_msg_system_endpoint_watermark_tx_evt_t arg)
        {
            log("ble_evt_system_endpoint_watermark_tx");
        }

        protected virtual void ble_evt_system_script_failure(ble_msg_system_script_failure_evt_t arg)
        {
            log("ble_evt_system_script_failure");
        }

        protected virtual void ble_evt_system_no_license_key(ble_msg_system_no_license_key_evt_t arg)
        {
            log("ble_evt_system_no_license_key");
        }

        protected virtual void ble_evt_system_protocol_error(ble_msg_system_protocol_error_evt_t arg)
        {
            log("ble_evt_system_protocol_error");
        }

        protected virtual void ble_evt_flash_ps_key(ble_msg_flash_ps_key_evt_t arg)
        {
            log("ble_evt_flash_ps_key");
        }

        protected virtual void ble_evt_attributes_value(ble_msg_attributes_value_evt_t arg)
        {
            log("ble_evt_attributes_value");
        }

        protected virtual void ble_evt_attributes_user_read_request(ble_msg_attributes_user_read_request_evt_t arg)
        {
            log("ble_evt_attributes_user_read_request");
        }

        protected virtual void ble_evt_attributes_status(ble_msg_attributes_status_evt_t arg)
        {
            log("ble_evt_attributes_status");
        }

        protected virtual void ble_evt_connection_status(ble_msg_connection_status_evt_t arg)
        {
            log("ble_evt_connection_status");
        }

        protected virtual void ble_evt_connection_version_ind(ble_msg_connection_version_ind_evt_t arg)
        {
            log("ble_evt_connection_version_ind");
        }

        protected virtual void ble_evt_connection_feature_ind(ble_msg_connection_feature_ind_evt_t arg)
        {
            log("ble_evt_connection_feature_ind");
        }

        protected virtual void ble_evt_connection_raw_rx(ble_msg_connection_raw_rx_evt_t arg)
        {
            log("ble_evt_connection_raw_rx");
        }

        protected virtual void ble_evt_connection_disconnected(ble_msg_connection_disconnected_evt_t arg)
        {
            log("ble_evt_connection_disconnected");
        }

        protected virtual void ble_evt_attclient_indicated(ble_msg_attclient_indicated_evt_t arg)
        {
            log("ble_evt_attclient_indicated");
        }

        protected virtual void ble_evt_attclient_procedure_completed(ble_msg_attclient_procedure_completed_evt_t arg)
        {
            log("ble_evt_attclient_procedure_completed");
        }

        protected virtual void ble_evt_attclient_group_found(ble_msg_attclient_group_found_evt_t arg)
        {
            log("ble_evt_attclient_group_found");
        }

        protected virtual void ble_evt_attclient_attribute_found(ble_msg_attclient_attribute_found_evt_t arg)
        {
            log("ble_evt_attclient_attribute_found");
        }

        protected virtual void ble_evt_attclient_find_information_found(ble_msg_attclient_find_information_found_evt_t arg)
        {
            log("ble_evt_attclient_find_information_found");
        }

        protected virtual void ble_evt_attclient_attribute_value(ble_msg_attclient_attribute_value_evt_t arg)
        {
            log("ble_evt_attclient_attribute_value");
        }

        protected virtual void ble_evt_attclient_read_multiple_response(ble_msg_attclient_read_multiple_response_evt_t arg)
        {
            log("ble_evt_attclient_read_multiple_response");
        }

        protected virtual void ble_evt_sm_smp_data(ble_msg_sm_smp_data_evt_t arg)
        {
            log("ble_evt_sm_smp_data");
        }

        protected virtual void ble_evt_sm_bonding_fail(ble_msg_sm_bonding_fail_evt_t arg)
        {
            log("ble_evt_sm_bonding_fail");
        }

        protected virtual void ble_evt_sm_passkey_display(ble_msg_sm_passkey_display_evt_t arg)
        {
            log("ble_evt_sm_passkey_display");
        }

        protected virtual void ble_evt_sm_passkey_request(ble_msg_sm_passkey_request_evt_t arg)
        {
            log("ble_evt_sm_passkey_request");
        }

        protected virtual void ble_evt_sm_bond_status(ble_msg_sm_bond_status_evt_t arg)
        {
            log("ble_evt_sm_bond_status");
        }

        protected virtual void ble_evt_gap_scan_response(ble_msg_gap_scan_response_evt_t arg)
        {
            log("ble_evt_gap_scan_response");
        }

        protected virtual void ble_evt_gap_mode_changed(ble_msg_gap_mode_changed_evt_t arg)
        {
            log("ble_evt_gap_mode_changed");
        }

        protected virtual void ble_evt_hardware_io_port_status(ble_msg_hardware_io_port_status_evt_t arg)
        {
            log("ble_evt_hardware_io_port_status");
        }

        protected virtual void ble_evt_hardware_soft_timer(ble_msg_hardware_soft_timer_evt_t arg)
        {
            log("ble_evt_hardware_soft_timer");
        }

        protected virtual void ble_evt_hardware_adc_result(ble_msg_hardware_adc_result_evt_t arg)
        {
            log("ble_evt_hardware_adc_result");
        }

        protected virtual void ble_evt_hardware_analog_comparator_status(ble_msg_hardware_analog_comparator_status_evt_t arg)
        {
            log("ble_evt_hardware_analog_comparator_status");
        }

        protected virtual void ble_evt_dfu_boot(ble_msg_dfu_boot_evt_t arg)
        {
            log("ble_evt_dfu_boot");
        }

        protected BgApiEventResponse parseEventResponse(BgApiEventResponse received)
        {
            int idx = SIZE_HEADER;
            BgApiEventResponse res = null;
            int _length = received.Length;
            byte[] buffer = received.Data;

            if(received.IsEvent)
            {
                switch(received.Class)
                {
                    case (byte)ble_classes.ble_cls_system:
                        switch(received.Id)
                        {
                            case (byte)ble_event_ids.ble_evt_system_boot_id:
                                {
                                    ble_msg_system_boot_evt_t s = new ble_msg_system_boot_evt_t();
                                    s.major = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.minor = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.patch = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.build = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.ll_version = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.protocol_version = buffer[idx++];
                                    s.hw = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_system_boot(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_system_debug_id:
                                {
                                    ble_msg_system_debug_evt_t s = new ble_msg_system_debug_evt_t();
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_system_debug(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_system_endpoint_watermark_rx_id:
                                {
                                    ble_msg_system_endpoint_watermark_rx_evt_t s = new ble_msg_system_endpoint_watermark_rx_evt_t();
                                    s.endpoint = buffer[idx++];
                                    s.data = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_system_endpoint_watermark_rx(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_system_endpoint_watermark_tx_id:
                                {
                                    ble_msg_system_endpoint_watermark_tx_evt_t s = new ble_msg_system_endpoint_watermark_tx_evt_t();
                                    s.endpoint = buffer[idx++];
                                    s.data = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_system_endpoint_watermark_tx(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_system_script_failure_id:
                                {
                                    ble_msg_system_script_failure_evt_t s = new ble_msg_system_script_failure_evt_t();
                                    s.address = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.reason = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_system_script_failure(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_system_no_license_key_id:
                                {
                                    ble_msg_system_no_license_key_evt_t s = new ble_msg_system_no_license_key_evt_t();
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_system_no_license_key(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_system_protocol_error_id:
                                {
                                    ble_msg_system_protocol_error_evt_t s = new ble_msg_system_protocol_error_evt_t();
                                    s.reason = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_system_protocol_error(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_flash:
                        switch(received.Id)
                        {
                            case (byte)ble_event_ids.ble_evt_flash_ps_key_id:
                                {
                                    ble_msg_flash_ps_key_evt_t s = new ble_msg_flash_ps_key_evt_t();
                                    s.key = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.value = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.value.Length; i++)
                                    {
                                        s.value[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_flash_ps_key(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_attributes:
                        switch(received.Id)
                        {
                            case (byte)ble_event_ids.ble_evt_attributes_value_id:
                                {
                                    ble_msg_attributes_value_evt_t s = new ble_msg_attributes_value_evt_t();
                                    s.connection = buffer[idx++];
                                    s.reason = buffer[idx++];
                                    s.handle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.offset = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.value = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.value.Length; i++)
                                    {
                                        s.value[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_attributes_value(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_attributes_user_read_request_id:
                                {
                                    ble_msg_attributes_user_read_request_evt_t s = new ble_msg_attributes_user_read_request_evt_t();
                                    s.connection = buffer[idx++];
                                    s.handle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.offset = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.maxsize = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_attributes_user_read_request(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_attributes_status_id:
                                {
                                    ble_msg_attributes_status_evt_t s = new ble_msg_attributes_status_evt_t();
                                    s.handle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.flags = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_attributes_status(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_connection:
                        switch(received.Id)
                        {
                            case (byte)ble_event_ids.ble_evt_connection_status_id:
                                {
                                    ble_msg_connection_status_evt_t s = new ble_msg_connection_status_evt_t();
                                    s.connection = buffer[idx++];
                                    s.flags = buffer[idx++];
                                    s.address = new bd_addr();
                                    for(int i = 0; i < s.address.Length; i++)
                                    {
                                        s.address.Address[i] = buffer[idx++];
                                    }
                                    s.address_type = buffer[idx++];
                                    s.conn_interval = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.timeout = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.latency = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.bonding = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_connection_status(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_connection_version_ind_id:
                                {
                                    ble_msg_connection_version_ind_evt_t s = new ble_msg_connection_version_ind_evt_t();
                                    s.connection = buffer[idx++];
                                    s.vers_nr = buffer[idx++];
                                    s.comp_id = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.sub_vers_nr = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_connection_version_ind(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_connection_feature_ind_id:
                                {
                                    ble_msg_connection_feature_ind_evt_t s = new ble_msg_connection_feature_ind_evt_t();
                                    s.connection = buffer[idx++];
                                    s.features = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.features.Length; i++)
                                    {
                                        s.features[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_connection_feature_ind(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_connection_raw_rx_id:
                                {
                                    ble_msg_connection_raw_rx_evt_t s = new ble_msg_connection_raw_rx_evt_t();
                                    s.connection = buffer[idx++];
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_connection_raw_rx(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_connection_disconnected_id:
                                {
                                    ble_msg_connection_disconnected_evt_t s = new ble_msg_connection_disconnected_evt_t();
                                    s.connection = buffer[idx++];
                                    s.reason = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_connection_disconnected(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_attclient:
                        switch(received.Id)
                        {
                            case (byte)ble_event_ids.ble_evt_attclient_indicated_id:
                                {
                                    ble_msg_attclient_indicated_evt_t s = new ble_msg_attclient_indicated_evt_t();
                                    s.connection = buffer[idx++];
                                    s.attrhandle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_attclient_indicated(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_attclient_procedure_completed_id:
                                {
                                    ble_msg_attclient_procedure_completed_evt_t s = new ble_msg_attclient_procedure_completed_evt_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.chrhandle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_attclient_procedure_completed(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_attclient_group_found_id:
                                {
                                    ble_msg_attclient_group_found_evt_t s = new ble_msg_attclient_group_found_evt_t();
                                    s.connection = buffer[idx++];
                                    s.start = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.end = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.uuid = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.uuid.Length; i++)
                                    {
                                        s.uuid[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_attclient_group_found(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_attclient_attribute_found_id:
                                {
                                    ble_msg_attclient_attribute_found_evt_t s = new ble_msg_attclient_attribute_found_evt_t();
                                    s.connection = buffer[idx++];
                                    s.chrdecl = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.value = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.properties = buffer[idx++];
                                    s.uuid = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.uuid.Length; i++)
                                    {
                                        s.uuid[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_attclient_attribute_found(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_attclient_find_information_found_id:
                                {
                                    ble_msg_attclient_find_information_found_evt_t s = new ble_msg_attclient_find_information_found_evt_t();
                                    s.connection = buffer[idx++];
                                    s.chrhandle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.uuid = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.uuid.Length; i++)
                                    {
                                        s.uuid[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_attclient_find_information_found(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_attclient_attribute_value_id:
                                {
                                    ble_msg_attclient_attribute_value_evt_t s = new ble_msg_attclient_attribute_value_evt_t();
                                    s.connection = buffer[idx++];
                                    s.atthandle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.type = buffer[idx++];
                                    s.value = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.value.Length; i++)
                                    {
                                        s.value[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_attclient_attribute_value(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_attclient_read_multiple_response_id:
                                {
                                    ble_msg_attclient_read_multiple_response_evt_t s = new ble_msg_attclient_read_multiple_response_evt_t();
                                    s.connection = buffer[idx++];
                                    s.handles = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.handles.Length; i++)
                                    {
                                        s.handles[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_attclient_read_multiple_response(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_sm:
                        switch(received.Id)
                        {
                            case (byte)ble_event_ids.ble_evt_sm_smp_data_id:
                                {
                                    ble_msg_sm_smp_data_evt_t s = new ble_msg_sm_smp_data_evt_t();
                                    s.handle = buffer[idx++];
                                    s.packet = buffer[idx++];
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_sm_smp_data(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_sm_bonding_fail_id:
                                {
                                    ble_msg_sm_bonding_fail_evt_t s = new ble_msg_sm_bonding_fail_evt_t();
                                    s.handle = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_sm_bonding_fail(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_sm_passkey_display_id:
                                {
                                    ble_msg_sm_passkey_display_evt_t s = new ble_msg_sm_passkey_display_evt_t();
                                    s.handle = buffer[idx++];
                                    s.passkey = buffer[idx+0] + buffer[idx+1] * 0x100 + buffer[idx+2] * 0x10000 + buffer[idx+3] * (long)0x1000000; idx += 4;
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_sm_passkey_display(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_sm_passkey_request_id:
                                {
                                    ble_msg_sm_passkey_request_evt_t s = new ble_msg_sm_passkey_request_evt_t();
                                    s.handle = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_sm_passkey_request(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_sm_bond_status_id:
                                {
                                    ble_msg_sm_bond_status_evt_t s = new ble_msg_sm_bond_status_evt_t();
                                    s.bond = buffer[idx++];
                                    s.keysize = buffer[idx++];
                                    s.mitm = buffer[idx++];
                                    s.keys = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_sm_bond_status(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_gap:
                        switch(received.Id)
                        {
                            case (byte)ble_event_ids.ble_evt_gap_scan_response_id:
                                {
                                    ble_msg_gap_scan_response_evt_t s = new ble_msg_gap_scan_response_evt_t();
                                    s.rssi = (sbyte)buffer[idx++];
                                    s.packet_type = buffer[idx++];
                                    s.sender = new bd_addr();
                                    for(int i = 0; i < s.sender.Length; i++)
                                    {
                                        s.sender.Address[i] = buffer[idx++];
                                    }
                                    s.address_type = buffer[idx++];
                                    s.bond = buffer[idx++];
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_gap_scan_response(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_gap_mode_changed_id:
                                {
                                    ble_msg_gap_mode_changed_evt_t s = new ble_msg_gap_mode_changed_evt_t();
                                    s.discover = buffer[idx++];
                                    s.connect = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_gap_mode_changed(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_hardware:
                        switch(received.Id)
                        {
                            case (byte)ble_event_ids.ble_evt_hardware_io_port_status_id:
                                {
                                    ble_msg_hardware_io_port_status_evt_t s = new ble_msg_hardware_io_port_status_evt_t();
                                    s.timestamp = buffer[idx+0] + buffer[idx+1] * 0x100 + buffer[idx+2] * 0x10000 + buffer[idx+3] * (long)0x1000000; idx += 4;
                                    s.port = buffer[idx++];
                                    s.irq = buffer[idx++];
                                    s.state = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_hardware_io_port_status(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_hardware_soft_timer_id:
                                {
                                    ble_msg_hardware_soft_timer_evt_t s = new ble_msg_hardware_soft_timer_evt_t();
                                    s.handle = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_hardware_soft_timer(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_hardware_adc_result_id:
                                {
                                    ble_msg_hardware_adc_result_evt_t s = new ble_msg_hardware_adc_result_evt_t();
                                    s.input = buffer[idx++];
                                    s.value = buffer[idx+0] | (((sbyte)buffer[idx+1]) << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_hardware_adc_result(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_event_ids.ble_evt_hardware_analog_comparator_status_id:
                                {
                                    ble_msg_hardware_analog_comparator_status_evt_t s = new ble_msg_hardware_analog_comparator_status_evt_t();
                                    s.timestamp = buffer[idx+0] + buffer[idx+1] * 0x100 + buffer[idx+2] * 0x10000 + buffer[idx+3] * (long)0x1000000; idx += 4;
                                    s.output = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_hardware_analog_comparator_status(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_test:
                        switch(received.Id)
                        {
                            default:
                                throw new BgApiException(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_dfu:
                        switch(received.Id)
                        {
                            case (byte)ble_event_ids.ble_evt_dfu_boot_id:
                                {
                                    ble_msg_dfu_boot_evt_t s = new ble_msg_dfu_boot_evt_t();
                                    s.version = buffer[idx+0] + buffer[idx+1] * 0x100 + buffer[idx+2] * 0x10000 + buffer[idx+3] * (long)0x1000000; idx += 4;
                                    check(idx, SIZE_HEADER + _length);
                                    ble_evt_dfu_boot(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown event id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    default:
                        throw new BgApiException(string.Format("Unknown class 0x{0}", buffer[2].ToString("X2")));
                }
            }
            else if(!received.IsEvent)
            {
                switch(received.Class)
                {
                    case (byte)ble_classes.ble_cls_system:
                        switch(received.Id)
                        {
                            case (byte)ble_command_ids.ble_cmd_system_hello_id:
                                {
                                    ble_msg_system_hello_rsp_t s = new ble_msg_system_hello_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_hello(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_address_get_id:
                                {
                                    ble_msg_system_address_get_rsp_t s = new ble_msg_system_address_get_rsp_t();
                                    s.address = new bd_addr();
                                    for(int i = 0; i < s.address.Length; i++)
                                    {
                                        s.address.Address[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_address_get(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_reg_write_id:
                                {
                                    ble_msg_system_reg_write_rsp_t s = new ble_msg_system_reg_write_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_reg_write(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_reg_read_id:
                                {
                                    ble_msg_system_reg_read_rsp_t s = new ble_msg_system_reg_read_rsp_t();
                                    s.address = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.value = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_reg_read(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_get_counters_id:
                                {
                                    ble_msg_system_get_counters_rsp_t s = new ble_msg_system_get_counters_rsp_t();
                                    s.txok = buffer[idx++];
                                    s.txretry = buffer[idx++];
                                    s.rxok = buffer[idx++];
                                    s.rxfail = buffer[idx++];
                                    s.mbuf = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_get_counters(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_get_connections_id:
                                {
                                    ble_msg_system_get_connections_rsp_t s = new ble_msg_system_get_connections_rsp_t();
                                    s.maxconn = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_get_connections(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_read_memory_id:
                                {
                                    ble_msg_system_read_memory_rsp_t s = new ble_msg_system_read_memory_rsp_t();
                                    s.address = buffer[idx+0] + buffer[idx+1] * 0x100 + buffer[idx+2] * 0x10000 + buffer[idx+3] * (long)0x1000000; idx += 4;
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_read_memory(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_get_info_id:
                                {
                                    ble_msg_system_get_info_rsp_t s = new ble_msg_system_get_info_rsp_t();
                                    s.major = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.minor = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.patch = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.build = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.ll_version = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.protocol_version = buffer[idx++];
                                    s.hw = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_get_info(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_endpoint_tx_id:
                                {
                                    ble_msg_system_endpoint_tx_rsp_t s = new ble_msg_system_endpoint_tx_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_endpoint_tx(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_whitelist_append_id:
                                {
                                    ble_msg_system_whitelist_append_rsp_t s = new ble_msg_system_whitelist_append_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_whitelist_append(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_whitelist_remove_id:
                                {
                                    ble_msg_system_whitelist_remove_rsp_t s = new ble_msg_system_whitelist_remove_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_whitelist_remove(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_whitelist_clear_id:
                                {
                                    ble_msg_system_whitelist_clear_rsp_t s = new ble_msg_system_whitelist_clear_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_whitelist_clear(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_endpoint_rx_id:
                                {
                                    ble_msg_system_endpoint_rx_rsp_t s = new ble_msg_system_endpoint_rx_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_endpoint_rx(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_endpoint_set_watermarks_id:
                                {
                                    ble_msg_system_endpoint_set_watermarks_rsp_t s = new ble_msg_system_endpoint_set_watermarks_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_endpoint_set_watermarks(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_aes_setkey_id:
                                {
                                    ble_msg_system_aes_setkey_rsp_t s = new ble_msg_system_aes_setkey_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_aes_setkey(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_aes_encrypt_id:
                                {
                                    ble_msg_system_aes_encrypt_rsp_t s = new ble_msg_system_aes_encrypt_rsp_t();
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_aes_encrypt(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_system_aes_decrypt_id:
                                {
                                    ble_msg_system_aes_decrypt_rsp_t s = new ble_msg_system_aes_decrypt_rsp_t();
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_system_aes_decrypt(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown response id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_flash:
                        switch(received.Id)
                        {
                            case (byte)ble_command_ids.ble_cmd_flash_ps_defrag_id:
                                {
                                    ble_msg_flash_ps_defrag_rsp_t s = new ble_msg_flash_ps_defrag_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_flash_ps_defrag(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_flash_ps_dump_id:
                                {
                                    ble_msg_flash_ps_dump_rsp_t s = new ble_msg_flash_ps_dump_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_flash_ps_dump(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_flash_ps_erase_all_id:
                                {
                                    ble_msg_flash_ps_erase_all_rsp_t s = new ble_msg_flash_ps_erase_all_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_flash_ps_erase_all(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_flash_ps_save_id:
                                {
                                    ble_msg_flash_ps_save_rsp_t s = new ble_msg_flash_ps_save_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_flash_ps_save(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_flash_ps_load_id:
                                {
                                    ble_msg_flash_ps_load_rsp_t s = new ble_msg_flash_ps_load_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.value = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.value.Length; i++)
                                    {
                                        s.value[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_flash_ps_load(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_flash_ps_erase_id:
                                {
                                    ble_msg_flash_ps_erase_rsp_t s = new ble_msg_flash_ps_erase_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_flash_ps_erase(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_flash_erase_page_id:
                                {
                                    ble_msg_flash_erase_page_rsp_t s = new ble_msg_flash_erase_page_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_flash_erase_page(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_flash_write_data_id:
                                {
                                    ble_msg_flash_write_data_rsp_t s = new ble_msg_flash_write_data_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_flash_write_data(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_flash_read_data_id:
                                {
                                    ble_msg_flash_read_data_rsp_t s = new ble_msg_flash_read_data_rsp_t();
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_flash_read_data(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown response id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_attributes:
                        switch(received.Id)
                        {
                            case (byte)ble_command_ids.ble_cmd_attributes_write_id:
                                {
                                    ble_msg_attributes_write_rsp_t s = new ble_msg_attributes_write_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attributes_write(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attributes_read_id:
                                {
                                    ble_msg_attributes_read_rsp_t s = new ble_msg_attributes_read_rsp_t();
                                    s.handle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.offset = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.value = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.value.Length; i++)
                                    {
                                        s.value[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attributes_read(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attributes_read_type_id:
                                {
                                    ble_msg_attributes_read_type_rsp_t s = new ble_msg_attributes_read_type_rsp_t();
                                    s.handle = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.value = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.value.Length; i++)
                                    {
                                        s.value[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attributes_read_type(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attributes_user_read_response_id:
                                {
                                    ble_msg_attributes_user_read_response_rsp_t s = new ble_msg_attributes_user_read_response_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attributes_user_read_response(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attributes_user_write_response_id:
                                {
                                    ble_msg_attributes_user_write_response_rsp_t s = new ble_msg_attributes_user_write_response_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attributes_user_write_response(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attributes_send_id:
                                {
                                    ble_msg_attributes_send_rsp_t s = new ble_msg_attributes_send_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attributes_send(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown response id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_connection:
                        switch(received.Id)
                        {
                            case (byte)ble_command_ids.ble_cmd_connection_disconnect_id:
                                {
                                    ble_msg_connection_disconnect_rsp_t s = new ble_msg_connection_disconnect_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_connection_disconnect(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_connection_get_rssi_id:
                                {
                                    ble_msg_connection_get_rssi_rsp_t s = new ble_msg_connection_get_rssi_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.rssi = (sbyte)buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_connection_get_rssi(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_connection_update_id:
                                {
                                    ble_msg_connection_update_rsp_t s = new ble_msg_connection_update_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_connection_update(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_connection_version_update_id:
                                {
                                    ble_msg_connection_version_update_rsp_t s = new ble_msg_connection_version_update_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_connection_version_update(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_connection_channel_map_get_id:
                                {
                                    ble_msg_connection_channel_map_get_rsp_t s = new ble_msg_connection_channel_map_get_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.map = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.map.Length; i++)
                                    {
                                        s.map[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_connection_channel_map_get(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_connection_channel_map_set_id:
                                {
                                    ble_msg_connection_channel_map_set_rsp_t s = new ble_msg_connection_channel_map_set_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_connection_channel_map_set(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_connection_features_get_id:
                                {
                                    ble_msg_connection_features_get_rsp_t s = new ble_msg_connection_features_get_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_connection_features_get(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_connection_get_status_id:
                                {
                                    ble_msg_connection_get_status_rsp_t s = new ble_msg_connection_get_status_rsp_t();
                                    s.connection = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_connection_get_status(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_connection_raw_tx_id:
                                {
                                    ble_msg_connection_raw_tx_rsp_t s = new ble_msg_connection_raw_tx_rsp_t();
                                    s.connection = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_connection_raw_tx(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_connection_slave_latency_disable_id:
                                {
                                    ble_msg_connection_slave_latency_disable_rsp_t s = new ble_msg_connection_slave_latency_disable_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_connection_slave_latency_disable(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown response id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_attclient:
                        switch(received.Id)
                        {
                            case (byte)ble_command_ids.ble_cmd_attclient_find_by_type_value_id:
                                {
                                    ble_msg_attclient_find_by_type_value_rsp_t s = new ble_msg_attclient_find_by_type_value_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_find_by_type_value(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_read_by_group_type_id:
                                {
                                    ble_msg_attclient_read_by_group_type_rsp_t s = new ble_msg_attclient_read_by_group_type_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_read_by_group_type(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_read_by_type_id:
                                {
                                    ble_msg_attclient_read_by_type_rsp_t s = new ble_msg_attclient_read_by_type_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_read_by_type(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_find_information_id:
                                {
                                    ble_msg_attclient_find_information_rsp_t s = new ble_msg_attclient_find_information_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_find_information(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_read_by_handle_id:
                                {
                                    ble_msg_attclient_read_by_handle_rsp_t s = new ble_msg_attclient_read_by_handle_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_read_by_handle(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_attribute_write_id:
                                {
                                    ble_msg_attclient_attribute_write_rsp_t s = new ble_msg_attclient_attribute_write_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_attribute_write(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_write_command_id:
                                {
                                    ble_msg_attclient_write_command_rsp_t s = new ble_msg_attclient_write_command_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_write_command(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_indicate_confirm_id:
                                {
                                    ble_msg_attclient_indicate_confirm_rsp_t s = new ble_msg_attclient_indicate_confirm_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_indicate_confirm(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_read_long_id:
                                {
                                    ble_msg_attclient_read_long_rsp_t s = new ble_msg_attclient_read_long_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_read_long(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_prepare_write_id:
                                {
                                    ble_msg_attclient_prepare_write_rsp_t s = new ble_msg_attclient_prepare_write_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_prepare_write(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_execute_write_id:
                                {
                                    ble_msg_attclient_execute_write_rsp_t s = new ble_msg_attclient_execute_write_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_execute_write(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_attclient_read_multiple_id:
                                {
                                    ble_msg_attclient_read_multiple_rsp_t s = new ble_msg_attclient_read_multiple_rsp_t();
                                    s.connection = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_attclient_read_multiple(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown response id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_sm:
                        switch(received.Id)
                        {
                            case (byte)ble_command_ids.ble_cmd_sm_encrypt_start_id:
                                {
                                    ble_msg_sm_encrypt_start_rsp_t s = new ble_msg_sm_encrypt_start_rsp_t();
                                    s.handle = buffer[idx++];
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_sm_encrypt_start(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_sm_set_bondable_mode_id:
                                {
                                    ble_msg_sm_set_bondable_mode_rsp_t s = new ble_msg_sm_set_bondable_mode_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_sm_set_bondable_mode(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_sm_delete_bonding_id:
                                {
                                    ble_msg_sm_delete_bonding_rsp_t s = new ble_msg_sm_delete_bonding_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_sm_delete_bonding(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_sm_set_parameters_id:
                                {
                                    ble_msg_sm_set_parameters_rsp_t s = new ble_msg_sm_set_parameters_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_sm_set_parameters(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_sm_passkey_entry_id:
                                {
                                    ble_msg_sm_passkey_entry_rsp_t s = new ble_msg_sm_passkey_entry_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_sm_passkey_entry(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_sm_get_bonds_id:
                                {
                                    ble_msg_sm_get_bonds_rsp_t s = new ble_msg_sm_get_bonds_rsp_t();
                                    s.bonds = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_sm_get_bonds(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_sm_set_oob_data_id:
                                {
                                    ble_msg_sm_set_oob_data_rsp_t s = new ble_msg_sm_set_oob_data_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_sm_set_oob_data(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_sm_whitelist_bonds_id:
                                {
                                    ble_msg_sm_whitelist_bonds_rsp_t s = new ble_msg_sm_whitelist_bonds_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.count = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_sm_whitelist_bonds(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown response id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_gap:
                        switch(received.Id)
                        {
                            case (byte)ble_command_ids.ble_cmd_gap_set_privacy_flags_id:
                                {
                                    ble_msg_gap_set_privacy_flags_rsp_t s = new ble_msg_gap_set_privacy_flags_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_set_privacy_flags(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_set_mode_id:
                                {
                                    ble_msg_gap_set_mode_rsp_t s = new ble_msg_gap_set_mode_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_set_mode(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_discover_id:
                                {
                                    ble_msg_gap_discover_rsp_t s = new ble_msg_gap_discover_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_discover(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_connect_direct_id:
                                {
                                    ble_msg_gap_connect_direct_rsp_t s = new ble_msg_gap_connect_direct_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.connection_handle = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_connect_direct(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_end_procedure_id:
                                {
                                    ble_msg_gap_end_procedure_rsp_t s = new ble_msg_gap_end_procedure_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_end_procedure(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_connect_selective_id:
                                {
                                    ble_msg_gap_connect_selective_rsp_t s = new ble_msg_gap_connect_selective_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.connection_handle = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_connect_selective(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_set_filtering_id:
                                {
                                    ble_msg_gap_set_filtering_rsp_t s = new ble_msg_gap_set_filtering_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_set_filtering(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_set_scan_parameters_id:
                                {
                                    ble_msg_gap_set_scan_parameters_rsp_t s = new ble_msg_gap_set_scan_parameters_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_set_scan_parameters(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_set_adv_parameters_id:
                                {
                                    ble_msg_gap_set_adv_parameters_rsp_t s = new ble_msg_gap_set_adv_parameters_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_set_adv_parameters(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_set_adv_data_id:
                                {
                                    ble_msg_gap_set_adv_data_rsp_t s = new ble_msg_gap_set_adv_data_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_set_adv_data(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_set_directed_connectable_mode_id:
                                {
                                    ble_msg_gap_set_directed_connectable_mode_rsp_t s = new ble_msg_gap_set_directed_connectable_mode_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_set_directed_connectable_mode(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_gap_set_initiating_con_parameters_id:
                                {
                                    ble_msg_gap_set_initiating_con_parameters_rsp_t s = new ble_msg_gap_set_initiating_con_parameters_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_gap_set_initiating_con_parameters(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown response id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_hardware:
                        switch(received.Id)
                        {
                            case (byte)ble_command_ids.ble_cmd_hardware_io_port_config_irq_id:
                                {
                                    ble_msg_hardware_io_port_config_irq_rsp_t s = new ble_msg_hardware_io_port_config_irq_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_io_port_config_irq(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_set_soft_timer_id:
                                {
                                    ble_msg_hardware_set_soft_timer_rsp_t s = new ble_msg_hardware_set_soft_timer_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_set_soft_timer(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_adc_read_id:
                                {
                                    ble_msg_hardware_adc_read_rsp_t s = new ble_msg_hardware_adc_read_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_adc_read(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_io_port_config_direction_id:
                                {
                                    ble_msg_hardware_io_port_config_direction_rsp_t s = new ble_msg_hardware_io_port_config_direction_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_io_port_config_direction(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_io_port_config_function_id:
                                {
                                    ble_msg_hardware_io_port_config_function_rsp_t s = new ble_msg_hardware_io_port_config_function_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_io_port_config_function(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_io_port_config_pull_id:
                                {
                                    ble_msg_hardware_io_port_config_pull_rsp_t s = new ble_msg_hardware_io_port_config_pull_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_io_port_config_pull(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_io_port_write_id:
                                {
                                    ble_msg_hardware_io_port_write_rsp_t s = new ble_msg_hardware_io_port_write_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_io_port_write(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_io_port_read_id:
                                {
                                    ble_msg_hardware_io_port_read_rsp_t s = new ble_msg_hardware_io_port_read_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.port = buffer[idx++];
                                    s.data = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_io_port_read(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_spi_config_id:
                                {
                                    ble_msg_hardware_spi_config_rsp_t s = new ble_msg_hardware_spi_config_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_spi_config(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_spi_transfer_id:
                                {
                                    ble_msg_hardware_spi_transfer_rsp_t s = new ble_msg_hardware_spi_transfer_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.channel = buffer[idx++];
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_spi_transfer(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_i2c_read_id:
                                {
                                    ble_msg_hardware_i2c_read_rsp_t s = new ble_msg_hardware_i2c_read_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.data = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.data.Length; i++)
                                    {
                                        s.data[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_i2c_read(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_i2c_write_id:
                                {
                                    ble_msg_hardware_i2c_write_rsp_t s = new ble_msg_hardware_i2c_write_rsp_t();
                                    s.written = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_i2c_write(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_set_txpower_id:
                                {
                                    ble_msg_hardware_set_txpower_rsp_t s = new ble_msg_hardware_set_txpower_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_set_txpower(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_timer_comparator_id:
                                {
                                    ble_msg_hardware_timer_comparator_rsp_t s = new ble_msg_hardware_timer_comparator_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_timer_comparator(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_io_port_irq_enable_id:
                                {
                                    ble_msg_hardware_io_port_irq_enable_rsp_t s = new ble_msg_hardware_io_port_irq_enable_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_io_port_irq_enable(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_io_port_irq_direction_id:
                                {
                                    ble_msg_hardware_io_port_irq_direction_rsp_t s = new ble_msg_hardware_io_port_irq_direction_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_io_port_irq_direction(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_analog_comparator_enable_id:
                                {
                                    ble_msg_hardware_analog_comparator_enable_rsp_t s = new ble_msg_hardware_analog_comparator_enable_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_analog_comparator_enable(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_analog_comparator_read_id:
                                {
                                    ble_msg_hardware_analog_comparator_read_rsp_t s = new ble_msg_hardware_analog_comparator_read_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    s.output = buffer[idx++];
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_analog_comparator_read(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_analog_comparator_config_irq_id:
                                {
                                    ble_msg_hardware_analog_comparator_config_irq_rsp_t s = new ble_msg_hardware_analog_comparator_config_irq_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_analog_comparator_config_irq(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_set_rxgain_id:
                                {
                                    ble_msg_hardware_set_rxgain_rsp_t s = new ble_msg_hardware_set_rxgain_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_set_rxgain(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_hardware_usb_enable_id:
                                {
                                    ble_msg_hardware_usb_enable_rsp_t s = new ble_msg_hardware_usb_enable_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_hardware_usb_enable(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown response id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_test:
                        switch(received.Id)
                        {
                            case (byte)ble_command_ids.ble_cmd_test_phy_tx_id:
                                {
                                    ble_msg_test_phy_tx_rsp_t s = new ble_msg_test_phy_tx_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_test_phy_tx(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_test_phy_rx_id:
                                {
                                    ble_msg_test_phy_rx_rsp_t s = new ble_msg_test_phy_rx_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_test_phy_rx(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_test_phy_end_id:
                                {
                                    ble_msg_test_phy_end_rsp_t s = new ble_msg_test_phy_end_rsp_t();
                                    s.counter = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_test_phy_end(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_test_phy_reset_id:
                                {
                                    ble_msg_test_phy_reset_rsp_t s = new ble_msg_test_phy_reset_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_test_phy_reset(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_test_get_channel_map_id:
                                {
                                    ble_msg_test_get_channel_map_rsp_t s = new ble_msg_test_get_channel_map_rsp_t();
                                    s.channel_map = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.channel_map.Length; i++)
                                    {
                                        s.channel_map[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_test_get_channel_map(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_test_debug_id:
                                {
                                    ble_msg_test_debug_rsp_t s = new ble_msg_test_debug_rsp_t();
                                    s.opcode = buffer[idx++];
                                    s.output = new byte[buffer[idx++]];
                                    for(int i = 0; i < s.output.Length; i++)
                                    {
                                        s.output[i] = buffer[idx++];
                                    }
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_test_debug(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_test_channel_mode_id:
                                {
                                    ble_msg_test_channel_mode_rsp_t s = new ble_msg_test_channel_mode_rsp_t();
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_test_channel_mode(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown response id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    case (byte)ble_classes.ble_cls_dfu:
                        switch(received.Id)
                        {
                            case (byte)ble_command_ids.ble_cmd_dfu_flash_set_address_id:
                                {
                                    ble_msg_dfu_flash_set_address_rsp_t s = new ble_msg_dfu_flash_set_address_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_dfu_flash_set_address(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_dfu_flash_upload_id:
                                {
                                    ble_msg_dfu_flash_upload_rsp_t s = new ble_msg_dfu_flash_upload_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_dfu_flash_upload(s);
                                    res = s;
                                }
                                break;
                            case (byte)ble_command_ids.ble_cmd_dfu_flash_upload_finish_id:
                                {
                                    ble_msg_dfu_flash_upload_finish_rsp_t s = new ble_msg_dfu_flash_upload_finish_rsp_t();
                                    s.result = buffer[idx+0] | (buffer[idx+1] << 8); idx+=2;
                                    check(idx, SIZE_HEADER + _length);
                                    //ble_cmd_dfu_flash_upload_finish(s);
                                    res = s;
                                }
                                break;
                            default:
                                throw new BgApiException(string.Format("Unknown response id 0x{0}", buffer[3].ToString("X2")));
                        }
                        break;
                    default:
                        throw new BgApiException(string.Format("Unknown class 0x{0}", buffer[2].ToString("X2")));
                }
            }
            res.Data = received.Data;
            return res;
        }
    }
}
