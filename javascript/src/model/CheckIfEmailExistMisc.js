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
 * The CheckIfEmailExistMisc model module.
 * @module model/CheckIfEmailExistMisc
 * @version 0.0.1
 */
class CheckIfEmailExistMisc {
    /**
     * Constructs a new <code>CheckIfEmailExistMisc</code>.
     * @alias module:model/CheckIfEmailExistMisc
     */
    constructor() { 
        
        CheckIfEmailExistMisc.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>CheckIfEmailExistMisc</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/CheckIfEmailExistMisc} obj Optional instance to populate.
     * @return {module:model/CheckIfEmailExistMisc} The populated <code>CheckIfEmailExistMisc</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new CheckIfEmailExistMisc();

            if (data.hasOwnProperty('is_disposable')) {
                obj['is_disposable'] = ApiClient.convertToType(data['is_disposable'], 'Boolean');
            }
            if (data.hasOwnProperty('is_role_account')) {
                obj['is_role_account'] = ApiClient.convertToType(data['is_role_account'], 'Boolean');
            }
        }
        return obj;
    }


}

/**
 * @member {Boolean} is_disposable
 */
CheckIfEmailExistMisc.prototype['is_disposable'] = undefined;

/**
 * @member {Boolean} is_role_account
 */
CheckIfEmailExistMisc.prototype['is_role_account'] = undefined;






export default CheckIfEmailExistMisc;

