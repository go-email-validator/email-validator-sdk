# coding: utf-8

"""
    Email Validator

    All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds.   # noqa: E501

    OpenAPI spec version: 0.0.1
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class CheckIfEmailExistMisc(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'is_disposable': 'bool',
        'is_role_account': 'bool'
    }

    attribute_map = {
        'is_disposable': 'is_disposable',
        'is_role_account': 'is_role_account'
    }

    def __init__(self, is_disposable=None, is_role_account=None):  # noqa: E501
        """CheckIfEmailExistMisc - a model defined in Swagger"""  # noqa: E501
        self._is_disposable = None
        self._is_role_account = None
        self.discriminator = None
        if is_disposable is not None:
            self.is_disposable = is_disposable
        if is_role_account is not None:
            self.is_role_account = is_role_account

    @property
    def is_disposable(self):
        """Gets the is_disposable of this CheckIfEmailExistMisc.  # noqa: E501


        :return: The is_disposable of this CheckIfEmailExistMisc.  # noqa: E501
        :rtype: bool
        """
        return self._is_disposable

    @is_disposable.setter
    def is_disposable(self, is_disposable):
        """Sets the is_disposable of this CheckIfEmailExistMisc.


        :param is_disposable: The is_disposable of this CheckIfEmailExistMisc.  # noqa: E501
        :type: bool
        """

        self._is_disposable = is_disposable

    @property
    def is_role_account(self):
        """Gets the is_role_account of this CheckIfEmailExistMisc.  # noqa: E501


        :return: The is_role_account of this CheckIfEmailExistMisc.  # noqa: E501
        :rtype: bool
        """
        return self._is_role_account

    @is_role_account.setter
    def is_role_account(self, is_role_account):
        """Sets the is_role_account of this CheckIfEmailExistMisc.


        :param is_role_account: The is_role_account of this CheckIfEmailExistMisc.  # noqa: E501
        :type: bool
        """

        self._is_role_account = is_role_account

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(CheckIfEmailExistMisc, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, CheckIfEmailExistMisc):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other