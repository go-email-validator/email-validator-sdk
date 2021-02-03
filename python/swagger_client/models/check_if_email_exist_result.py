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

class CheckIfEmailExistResult(object):
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
        'input': 'str',
        'is_reachable': 'str',
        'misc': 'CheckIfEmailExistMisc',
        'mx': 'CheckIfEmailExistMX',
        'smtp': 'CheckIfEmailExistSMTP',
        'syntax': 'CheckIfEmailExistSyntax',
        'error': 'str'
    }

    attribute_map = {
        'input': 'input',
        'is_reachable': 'is_reachable',
        'misc': 'misc',
        'mx': 'mx',
        'smtp': 'smtp',
        'syntax': 'syntax',
        'error': 'error'
    }

    def __init__(self, input=None, is_reachable=None, misc=None, mx=None, smtp=None, syntax=None, error=None):  # noqa: E501
        """CheckIfEmailExistResult - a model defined in Swagger"""  # noqa: E501
        self._input = None
        self._is_reachable = None
        self._misc = None
        self._mx = None
        self._smtp = None
        self._syntax = None
        self._error = None
        self.discriminator = None
        if input is not None:
            self.input = input
        if is_reachable is not None:
            self.is_reachable = is_reachable
        if misc is not None:
            self.misc = misc
        if mx is not None:
            self.mx = mx
        if smtp is not None:
            self.smtp = smtp
        if syntax is not None:
            self.syntax = syntax
        if error is not None:
            self.error = error

    @property
    def input(self):
        """Gets the input of this CheckIfEmailExistResult.  # noqa: E501


        :return: The input of this CheckIfEmailExistResult.  # noqa: E501
        :rtype: str
        """
        return self._input

    @input.setter
    def input(self, input):
        """Sets the input of this CheckIfEmailExistResult.


        :param input: The input of this CheckIfEmailExistResult.  # noqa: E501
        :type: str
        """

        self._input = input

    @property
    def is_reachable(self):
        """Gets the is_reachable of this CheckIfEmailExistResult.  # noqa: E501


        :return: The is_reachable of this CheckIfEmailExistResult.  # noqa: E501
        :rtype: str
        """
        return self._is_reachable

    @is_reachable.setter
    def is_reachable(self, is_reachable):
        """Sets the is_reachable of this CheckIfEmailExistResult.


        :param is_reachable: The is_reachable of this CheckIfEmailExistResult.  # noqa: E501
        :type: str
        """

        self._is_reachable = is_reachable

    @property
    def misc(self):
        """Gets the misc of this CheckIfEmailExistResult.  # noqa: E501


        :return: The misc of this CheckIfEmailExistResult.  # noqa: E501
        :rtype: CheckIfEmailExistMisc
        """
        return self._misc

    @misc.setter
    def misc(self, misc):
        """Sets the misc of this CheckIfEmailExistResult.


        :param misc: The misc of this CheckIfEmailExistResult.  # noqa: E501
        :type: CheckIfEmailExistMisc
        """

        self._misc = misc

    @property
    def mx(self):
        """Gets the mx of this CheckIfEmailExistResult.  # noqa: E501


        :return: The mx of this CheckIfEmailExistResult.  # noqa: E501
        :rtype: CheckIfEmailExistMX
        """
        return self._mx

    @mx.setter
    def mx(self, mx):
        """Sets the mx of this CheckIfEmailExistResult.


        :param mx: The mx of this CheckIfEmailExistResult.  # noqa: E501
        :type: CheckIfEmailExistMX
        """

        self._mx = mx

    @property
    def smtp(self):
        """Gets the smtp of this CheckIfEmailExistResult.  # noqa: E501


        :return: The smtp of this CheckIfEmailExistResult.  # noqa: E501
        :rtype: CheckIfEmailExistSMTP
        """
        return self._smtp

    @smtp.setter
    def smtp(self, smtp):
        """Sets the smtp of this CheckIfEmailExistResult.


        :param smtp: The smtp of this CheckIfEmailExistResult.  # noqa: E501
        :type: CheckIfEmailExistSMTP
        """

        self._smtp = smtp

    @property
    def syntax(self):
        """Gets the syntax of this CheckIfEmailExistResult.  # noqa: E501


        :return: The syntax of this CheckIfEmailExistResult.  # noqa: E501
        :rtype: CheckIfEmailExistSyntax
        """
        return self._syntax

    @syntax.setter
    def syntax(self, syntax):
        """Sets the syntax of this CheckIfEmailExistResult.


        :param syntax: The syntax of this CheckIfEmailExistResult.  # noqa: E501
        :type: CheckIfEmailExistSyntax
        """

        self._syntax = syntax

    @property
    def error(self):
        """Gets the error of this CheckIfEmailExistResult.  # noqa: E501


        :return: The error of this CheckIfEmailExistResult.  # noqa: E501
        :rtype: str
        """
        return self._error

    @error.setter
    def error(self, error):
        """Sets the error of this CheckIfEmailExistResult.


        :param error: The error of this CheckIfEmailExistResult.  # noqa: E501
        :type: str
        """

        self._error = error

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
        if issubclass(CheckIfEmailExistResult, dict):
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
        if not isinstance(other, CheckIfEmailExistResult):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
