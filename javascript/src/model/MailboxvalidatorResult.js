/**
 * Email Validator
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds. 
 *
 * The version of the OpenAPI document: 0.0.1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';

/**
 * The MailboxvalidatorResult model module.
 * @module model/MailboxvalidatorResult
 * @version 0.0.1
 */
class MailboxvalidatorResult {
    /**
     * Constructs a new <code>MailboxvalidatorResult</code>.
     * @alias module:model/MailboxvalidatorResult
     */
    constructor() { 
        
        MailboxvalidatorResult.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>MailboxvalidatorResult</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/MailboxvalidatorResult} obj Optional instance to populate.
     * @return {module:model/MailboxvalidatorResult} The populated <code>MailboxvalidatorResult</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new MailboxvalidatorResult();

            if (data.hasOwnProperty('email_address')) {
                obj['email_address'] = ApiClient.convertToType(data['email_address'], 'String');
            }
            if (data.hasOwnProperty('domain')) {
                obj['domain'] = ApiClient.convertToType(data['domain'], 'String');
            }
            if (data.hasOwnProperty('is_free')) {
                obj['is_free'] = ApiClient.convertToType(data['is_free'], 'String');
            }
            if (data.hasOwnProperty('is_syntax')) {
                obj['is_syntax'] = ApiClient.convertToType(data['is_syntax'], 'String');
            }
            if (data.hasOwnProperty('is_domain')) {
                obj['is_domain'] = ApiClient.convertToType(data['is_domain'], 'String');
            }
            if (data.hasOwnProperty('is_smtp')) {
                obj['is_smtp'] = ApiClient.convertToType(data['is_smtp'], 'String');
            }
            if (data.hasOwnProperty('is_verified')) {
                obj['is_verified'] = ApiClient.convertToType(data['is_verified'], 'String');
            }
            if (data.hasOwnProperty('is_server_down')) {
                obj['is_server_down'] = ApiClient.convertToType(data['is_server_down'], 'String');
            }
            if (data.hasOwnProperty('is_greylisted')) {
                obj['is_greylisted'] = ApiClient.convertToType(data['is_greylisted'], 'String');
            }
            if (data.hasOwnProperty('is_disposable')) {
                obj['is_disposable'] = ApiClient.convertToType(data['is_disposable'], 'String');
            }
            if (data.hasOwnProperty('is_suppressed')) {
                obj['is_suppressed'] = ApiClient.convertToType(data['is_suppressed'], 'String');
            }
            if (data.hasOwnProperty('is_role')) {
                obj['is_role'] = ApiClient.convertToType(data['is_role'], 'String');
            }
            if (data.hasOwnProperty('is_high_risk')) {
                obj['is_high_risk'] = ApiClient.convertToType(data['is_high_risk'], 'String');
            }
            if (data.hasOwnProperty('is_catchall')) {
                obj['is_catchall'] = ApiClient.convertToType(data['is_catchall'], 'String');
            }
            if (data.hasOwnProperty('mailboxvalidator_score')) {
                obj['mailboxvalidator_score'] = ApiClient.convertToType(data['mailboxvalidator_score'], 'String');
            }
            if (data.hasOwnProperty('time_taken')) {
                obj['time_taken'] = ApiClient.convertToType(data['time_taken'], 'String');
            }
            if (data.hasOwnProperty('status')) {
                obj['status'] = ApiClient.convertToType(data['status'], 'String');
            }
            if (data.hasOwnProperty('credits_available')) {
                obj['credits_available'] = ApiClient.convertToType(data['credits_available'], 'Number');
            }
            if (data.hasOwnProperty('error_code')) {
                obj['error_code'] = ApiClient.convertToType(data['error_code'], 'String');
            }
            if (data.hasOwnProperty('error_message')) {
                obj['error_message'] = ApiClient.convertToType(data['error_message'], 'String');
            }
        }
        return obj;
    }


}

/**
 * @member {String} email_address
 */
MailboxvalidatorResult.prototype['email_address'] = undefined;

/**
 * @member {String} domain
 */
MailboxvalidatorResult.prototype['domain'] = undefined;

/**
 * @member {String} is_free
 */
MailboxvalidatorResult.prototype['is_free'] = undefined;

/**
 * @member {String} is_syntax
 */
MailboxvalidatorResult.prototype['is_syntax'] = undefined;

/**
 * @member {String} is_domain
 */
MailboxvalidatorResult.prototype['is_domain'] = undefined;

/**
 * @member {String} is_smtp
 */
MailboxvalidatorResult.prototype['is_smtp'] = undefined;

/**
 * @member {String} is_verified
 */
MailboxvalidatorResult.prototype['is_verified'] = undefined;

/**
 * @member {String} is_server_down
 */
MailboxvalidatorResult.prototype['is_server_down'] = undefined;

/**
 * @member {String} is_greylisted
 */
MailboxvalidatorResult.prototype['is_greylisted'] = undefined;

/**
 * @member {String} is_disposable
 */
MailboxvalidatorResult.prototype['is_disposable'] = undefined;

/**
 * @member {String} is_suppressed
 */
MailboxvalidatorResult.prototype['is_suppressed'] = undefined;

/**
 * @member {String} is_role
 */
MailboxvalidatorResult.prototype['is_role'] = undefined;

/**
 * @member {String} is_high_risk
 */
MailboxvalidatorResult.prototype['is_high_risk'] = undefined;

/**
 * @member {String} is_catchall
 */
MailboxvalidatorResult.prototype['is_catchall'] = undefined;

/**
 * @member {String} mailboxvalidator_score
 */
MailboxvalidatorResult.prototype['mailboxvalidator_score'] = undefined;

/**
 * @member {String} time_taken
 */
MailboxvalidatorResult.prototype['time_taken'] = undefined;

/**
 * @member {String} status
 */
MailboxvalidatorResult.prototype['status'] = undefined;

/**
 * @member {Number} credits_available
 */
MailboxvalidatorResult.prototype['credits_available'] = undefined;

/**
 * @member {String} error_code
 */
MailboxvalidatorResult.prototype['error_code'] = undefined;

/**
 * @member {String} error_message
 */
MailboxvalidatorResult.prototype['error_message'] = undefined;






export default MailboxvalidatorResult;

