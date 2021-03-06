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
import EmailRequestSmtp from './EmailRequestSmtp';
import ResultType from './ResultType';

/**
 * The EmailRequest model module.
 * @module model/EmailRequest
 * @version 0.0.1
 */
class EmailRequest {
    /**
     * Constructs a new <code>EmailRequest</code>.
     * @alias module:model/EmailRequest
     */
    constructor() { 
        
        EmailRequest.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>EmailRequest</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/EmailRequest} obj Optional instance to populate.
     * @return {module:model/EmailRequest} The populated <code>EmailRequest</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new EmailRequest();

            if (data.hasOwnProperty('email')) {
                obj['email'] = ApiClient.convertToType(data['email'], 'String');
            }
            if (data.hasOwnProperty('smtp')) {
                obj['smtp'] = EmailRequestSmtp.constructFromObject(data['smtp']);
            }
            if (data.hasOwnProperty('result_type')) {
                obj['result_type'] = ResultType.constructFromObject(data['result_type']);
            }
        }
        return obj;
    }


}

/**
 * @member {String} email
 */
EmailRequest.prototype['email'] = undefined;

/**
 * @member {module:model/EmailRequestSmtp} smtp
 */
EmailRequest.prototype['smtp'] = undefined;

/**
 * @member {module:model/ResultType} result_type
 */
EmailRequest.prototype['result_type'] = undefined;






export default EmailRequest;

