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
 * The UnexpectedError model module.
 * @module model/UnexpectedError
 * @version 0.0.1
 */
class UnexpectedError {
    /**
     * Constructs a new <code>UnexpectedError</code>.
     * @alias module:model/UnexpectedError
     */
    constructor() { 
        
        UnexpectedError.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>UnexpectedError</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/UnexpectedError} obj Optional instance to populate.
     * @return {module:model/UnexpectedError} The populated <code>UnexpectedError</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new UnexpectedError();

            if (data.hasOwnProperty('code')) {
                obj['code'] = ApiClient.convertToType(data['code'], 'Number');
            }
            if (data.hasOwnProperty('message')) {
                obj['message'] = ApiClient.convertToType(data['message'], 'String');
            }
            if (data.hasOwnProperty('details')) {
                obj['details'] = ApiClient.convertToType(data['details'], {'String': Object});
            }
        }
        return obj;
    }


}

/**
 * @member {Number} code
 */
UnexpectedError.prototype['code'] = undefined;

/**
 * @member {String} message
 */
UnexpectedError.prototype['message'] = undefined;

/**
 * @member {Object.<String, Object>} details
 */
UnexpectedError.prototype['details'] = undefined;






export default UnexpectedError;

