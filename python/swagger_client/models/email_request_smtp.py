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

class EmailRequestSmtp(object):
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
        'email_from': 'str',
        'hello_name': 'str',
        'proxy': 'str',
        'timeout_connection': 'float',
        'timeout_response': 'float',
        'port': 'int'
    }

    attribute_map = {
        'email_from': 'email_from',
        'hello_name': 'hello_name',
        'proxy': 'proxy',
        'timeout_connection': 'timeout_connection',
        'timeout_response': 'timeout_response',
        'port': 'port'
    }

    def __init__(self, email_from=None, hello_name='localhost', proxy=None, timeout_connection=5.0, timeout_response=None, port=25):  # noqa: E501
        """EmailRequestSmtp - a model defined in Swagger"""  # noqa: E501
        self._email_from = None
        self._hello_name = None
        self._proxy = None
        self._timeout_connection = None
        self._timeout_response = None
        self._port = None
        self.discriminator = None
        if email_from is not None:
            self.email_from = email_from
        if hello_name is not None:
            self.hello_name = hello_name
        if proxy is not None:
            self.proxy = proxy
        if timeout_connection is not None:
            self.timeout_connection = timeout_connection
        if timeout_response is not None:
            self.timeout_response = timeout_response
        if port is not None:
            self.port = port

    @property
    def email_from(self):
        """Gets the email_from of this EmailRequestSmtp.  # noqa: E501


        :return: The email_from of this EmailRequestSmtp.  # noqa: E501
        :rtype: str
        """
        return self._email_from

    @email_from.setter
    def email_from(self, email_from):
        """Sets the email_from of this EmailRequestSmtp.


        :param email_from: The email_from of this EmailRequestSmtp.  # noqa: E501
        :type: str
        """

        self._email_from = email_from

    @property
    def hello_name(self):
        """Gets the hello_name of this EmailRequestSmtp.  # noqa: E501


        :return: The hello_name of this EmailRequestSmtp.  # noqa: E501
        :rtype: str
        """
        return self._hello_name

    @hello_name.setter
    def hello_name(self, hello_name):
        """Sets the hello_name of this EmailRequestSmtp.


        :param hello_name: The hello_name of this EmailRequestSmtp.  # noqa: E501
        :type: str
        """

        self._hello_name = hello_name

    @property
    def proxy(self):
        """Gets the proxy of this EmailRequestSmtp.  # noqa: E501

        Versions - SOCKS4, SOCKS4A and SOCKS5. Format -  schema://username:password@host:port.   # noqa: E501

        :return: The proxy of this EmailRequestSmtp.  # noqa: E501
        :rtype: str
        """
        return self._proxy

    @proxy.setter
    def proxy(self, proxy):
        """Sets the proxy of this EmailRequestSmtp.

        Versions - SOCKS4, SOCKS4A and SOCKS5. Format -  schema://username:password@host:port.   # noqa: E501

        :param proxy: The proxy of this EmailRequestSmtp.  # noqa: E501
        :type: str
        """

        self._proxy = proxy

    @property
    def timeout_connection(self):
        """Gets the timeout_connection of this EmailRequestSmtp.  # noqa: E501

        timeout creating smtp connection  # noqa: E501

        :return: The timeout_connection of this EmailRequestSmtp.  # noqa: E501
        :rtype: float
        """
        return self._timeout_connection

    @timeout_connection.setter
    def timeout_connection(self, timeout_connection):
        """Sets the timeout_connection of this EmailRequestSmtp.

        timeout creating smtp connection  # noqa: E501

        :param timeout_connection: The timeout_connection of this EmailRequestSmtp.  # noqa: E501
        :type: float
        """

        self._timeout_connection = timeout_connection

    @property
    def timeout_response(self):
        """Gets the timeout_response of this EmailRequestSmtp.  # noqa: E501

        timeout of communication with smtp server  # noqa: E501

        :return: The timeout_response of this EmailRequestSmtp.  # noqa: E501
        :rtype: float
        """
        return self._timeout_response

    @timeout_response.setter
    def timeout_response(self, timeout_response):
        """Sets the timeout_response of this EmailRequestSmtp.

        timeout of communication with smtp server  # noqa: E501

        :param timeout_response: The timeout_response of this EmailRequestSmtp.  # noqa: E501
        :type: float
        """

        self._timeout_response = timeout_response

    @property
    def port(self):
        """Gets the port of this EmailRequestSmtp.  # noqa: E501

        smtp port remote server  # noqa: E501

        :return: The port of this EmailRequestSmtp.  # noqa: E501
        :rtype: int
        """
        return self._port

    @port.setter
    def port(self, port):
        """Sets the port of this EmailRequestSmtp.

        smtp port remote server  # noqa: E501

        :param port: The port of this EmailRequestSmtp.  # noqa: E501
        :type: int
        """

        self._port = port

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
        if issubclass(EmailRequestSmtp, dict):
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
        if not isinstance(other, EmailRequestSmtp):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
