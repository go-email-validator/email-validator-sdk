"""
    Email Validator

    All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds.   # noqa: E501

    The version of the OpenAPI document: 0.0.1
    Generated by: https://openapi-generator.tech
"""


import re  # noqa: F401
import sys  # noqa: F401

import nulltype  # noqa: F401

from openapi_client.model_utils import (  # noqa: F401
    ApiTypeError,
    ModelComposed,
    ModelNormal,
    ModelSimple,
    cached_property,
    change_keys_js_to_python,
    convert_js_args_to_python_args,
    date,
    datetime,
    file_type,
    none_type,
    validate_get_composed_info,
)

def lazy_import():
    from openapi_client.model.check_if_email_exist_misc import CheckIfEmailExistMisc
    from openapi_client.model.check_if_email_exist_mx import CheckIfEmailExistMX
    from openapi_client.model.check_if_email_exist_result import CheckIfEmailExistResult
    from openapi_client.model.check_if_email_exist_smtp import CheckIfEmailExistSMTP
    from openapi_client.model.check_if_email_exist_syntax import CheckIfEmailExistSyntax
    from openapi_client.model.mailboxvalidator_result import MailboxvalidatorResult
    from openapi_client.model.prompt_email_verification_api_mx import PromptEmailVerificationApiMX
    from openapi_client.model.prompt_email_verification_api_result import PromptEmailVerificationApiResult
    globals()['CheckIfEmailExistMX'] = CheckIfEmailExistMX
    globals()['CheckIfEmailExistMisc'] = CheckIfEmailExistMisc
    globals()['CheckIfEmailExistResult'] = CheckIfEmailExistResult
    globals()['CheckIfEmailExistSMTP'] = CheckIfEmailExistSMTP
    globals()['CheckIfEmailExistSyntax'] = CheckIfEmailExistSyntax
    globals()['MailboxvalidatorResult'] = MailboxvalidatorResult
    globals()['PromptEmailVerificationApiMX'] = PromptEmailVerificationApiMX
    globals()['PromptEmailVerificationApiResult'] = PromptEmailVerificationApiResult


class EmailResponse(ModelComposed):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.

    Attributes:
      allowed_values (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          with a capitalized key describing the allowed value and an allowed
          value. These dicts store the allowed enum values.
      attribute_map (dict): The key is attribute name
          and the value is json key in definition.
      discriminator_value_class_map (dict): A dict to go from the discriminator
          variable value to the discriminator class name.
      validations (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          that stores validations for max_length, min_length, max_items,
          min_items, exclusive_maximum, inclusive_maximum, exclusive_minimum,
          inclusive_minimum, and regex.
      additional_properties_type (tuple): A tuple of classes accepted
          as additional properties values.
    """

    allowed_values = {
    }

    validations = {
    }

    @cached_property
    def additional_properties_type():
        """
        This must be a method because a model may have properties that are
        of type self, this must run after the class is loaded
        """
        lazy_import()
        return (bool, date, datetime, dict, float, int, list, str, none_type,)  # noqa: E501

    _nullable = False

    @cached_property
    def openapi_types():
        """
        This must be a method because a model may have properties that are
        of type self, this must run after the class is loaded

        Returns
            openapi_types (dict): The key is attribute name
                and the value is attribute type.
        """
        lazy_import()
        return {
            'input': (str,),  # noqa: E501
            'is_reachable': (str,),  # noqa: E501
            'misc': (CheckIfEmailExistMisc,),  # noqa: E501
            'mx': (CheckIfEmailExistMX,),  # noqa: E501
            'smtp': (CheckIfEmailExistSMTP,),  # noqa: E501
            'syntax': (CheckIfEmailExistSyntax,),  # noqa: E501
            'error': (str,),  # noqa: E501
            'email_address': (str,),  # noqa: E501
            'domain': (str,),  # noqa: E501
            'is_free': (str,),  # noqa: E501
            'is_syntax': (str,),  # noqa: E501
            'is_domain': (str,),  # noqa: E501
            'is_smtp': (str,),  # noqa: E501
            'is_verified': (str,),  # noqa: E501
            'is_server_down': (str,),  # noqa: E501
            'is_greylisted': (str,),  # noqa: E501
            'is_disposable': (bool,),  # noqa: E501
            'is_suppressed': (str,),  # noqa: E501
            'is_role': (str,),  # noqa: E501
            'is_high_risk': (str,),  # noqa: E501
            'is_catchall': (str,),  # noqa: E501
            'mailboxvalidator_score': (str,),  # noqa: E501
            'time_taken': (str,),  # noqa: E501
            'status': (str,),  # noqa: E501
            'credits_available': (int,),  # noqa: E501
            'error_code': (str,),  # noqa: E501
            'error_message': (str,),  # noqa: E501
            'can_connect_smtp': (bool,),  # noqa: E501
            'email': (str,),  # noqa: E501
            'is_catch_all': (bool,),  # noqa: E501
            'is_deliverable': (bool,),  # noqa: E501
            'is_disabled': (bool,),  # noqa: E501
            'is_inbox_full': (bool,),  # noqa: E501
            'is_role_account': (bool,),  # noqa: E501
            'mx_records': (PromptEmailVerificationApiMX,),  # noqa: E501
            'syntax_valid': (bool,),  # noqa: E501
            'message': (str,),  # noqa: E501
        }

    @cached_property
    def discriminator():
        return None


    attribute_map = {
        'input': 'input',  # noqa: E501
        'is_reachable': 'is_reachable',  # noqa: E501
        'misc': 'misc',  # noqa: E501
        'mx': 'mx',  # noqa: E501
        'smtp': 'smtp',  # noqa: E501
        'syntax': 'syntax',  # noqa: E501
        'error': 'error',  # noqa: E501
        'email_address': 'email_address',  # noqa: E501
        'domain': 'domain',  # noqa: E501
        'is_free': 'is_free',  # noqa: E501
        'is_syntax': 'is_syntax',  # noqa: E501
        'is_domain': 'is_domain',  # noqa: E501
        'is_smtp': 'is_smtp',  # noqa: E501
        'is_verified': 'is_verified',  # noqa: E501
        'is_server_down': 'is_server_down',  # noqa: E501
        'is_greylisted': 'is_greylisted',  # noqa: E501
        'is_disposable': 'is_disposable',  # noqa: E501
        'is_suppressed': 'is_suppressed',  # noqa: E501
        'is_role': 'is_role',  # noqa: E501
        'is_high_risk': 'is_high_risk',  # noqa: E501
        'is_catchall': 'is_catchall',  # noqa: E501
        'mailboxvalidator_score': 'mailboxvalidator_score',  # noqa: E501
        'time_taken': 'time_taken',  # noqa: E501
        'status': 'status',  # noqa: E501
        'credits_available': 'credits_available',  # noqa: E501
        'error_code': 'error_code',  # noqa: E501
        'error_message': 'error_message',  # noqa: E501
        'can_connect_smtp': 'can_connect_smtp',  # noqa: E501
        'email': 'email',  # noqa: E501
        'is_catch_all': 'is_catch_all',  # noqa: E501
        'is_deliverable': 'is_deliverable',  # noqa: E501
        'is_disabled': 'is_disabled',  # noqa: E501
        'is_inbox_full': 'is_inbox_full',  # noqa: E501
        'is_role_account': 'is_role_account',  # noqa: E501
        'mx_records': 'mx_records',  # noqa: E501
        'syntax_valid': 'syntax_valid',  # noqa: E501
        'message': 'message',  # noqa: E501
    }

    required_properties = set([
        '_data_store',
        '_check_type',
        '_spec_property_naming',
        '_path_to_item',
        '_configuration',
        '_visited_composed_classes',
        '_composed_instances',
        '_var_name_to_model_instances',
        '_additional_properties_model_instances',
    ])

    @convert_js_args_to_python_args
    def __init__(self, *args, **kwargs):  # noqa: E501
        """EmailResponse - a model defined in OpenAPI

        Keyword Args:
            _check_type (bool): if True, values for parameters in openapi_types
                                will be type checked and a TypeError will be
                                raised if the wrong type is input.
                                Defaults to True
            _path_to_item (tuple/list): This is a list of keys or values to
                                drill down to the model in received_data
                                when deserializing a response
            _spec_property_naming (bool): True if the variable names in the input data
                                are serialized names, as specified in the OpenAPI document.
                                False if the variable names in the input data
                                are pythonic names, e.g. snake case (default)
            _configuration (Configuration): the instance to use when
                                deserializing a file_type parameter.
                                If passed, type conversion is attempted
                                If omitted no type conversion is done.
            _visited_composed_classes (tuple): This stores a tuple of
                                classes that we have traveled through so that
                                if we see that class again we will not use its
                                discriminator again.
                                When traveling through a discriminator, the
                                composed schema that is
                                is traveled through is added to this set.
                                For example if Animal has a discriminator
                                petType and we pass in "Dog", and the class Dog
                                allOf includes Animal, we move through Animal
                                once using the discriminator, and pick Dog.
                                Then in Dog, we will make an instance of the
                                Animal class but this time we won't travel
                                through its discriminator because we passed in
                                _visited_composed_classes = (Animal,)
            input (str): [optional]  # noqa: E501
            is_reachable (str): [optional]  # noqa: E501
            misc (CheckIfEmailExistMisc): [optional]  # noqa: E501
            mx (CheckIfEmailExistMX): [optional]  # noqa: E501
            smtp (CheckIfEmailExistSMTP): [optional]  # noqa: E501
            syntax (CheckIfEmailExistSyntax): [optional]  # noqa: E501
            error (str): [optional]  # noqa: E501
            email_address (str): [optional]  # noqa: E501
            domain (str): [optional]  # noqa: E501
            is_free (str): [optional]  # noqa: E501
            is_syntax (str): [optional]  # noqa: E501
            is_domain (str): [optional]  # noqa: E501
            is_smtp (str): [optional]  # noqa: E501
            is_verified (str): [optional]  # noqa: E501
            is_server_down (str): [optional]  # noqa: E501
            is_greylisted (str): [optional]  # noqa: E501
            is_disposable (bool): [optional]  # noqa: E501
            is_suppressed (str): [optional]  # noqa: E501
            is_role (str): [optional]  # noqa: E501
            is_high_risk (str): [optional]  # noqa: E501
            is_catchall (str): [optional]  # noqa: E501
            mailboxvalidator_score (str): [optional]  # noqa: E501
            time_taken (str): [optional]  # noqa: E501
            status (str): [optional]  # noqa: E501
            credits_available (int): [optional]  # noqa: E501
            error_code (str): [optional]  # noqa: E501
            error_message (str): [optional]  # noqa: E501
            can_connect_smtp (bool): [optional]  # noqa: E501
            email (str): [optional]  # noqa: E501
            is_catch_all (bool): [optional]  # noqa: E501
            is_deliverable (bool): [optional]  # noqa: E501
            is_disabled (bool): [optional]  # noqa: E501
            is_inbox_full (bool): [optional]  # noqa: E501
            is_role_account (bool): [optional]  # noqa: E501
            mx_records (PromptEmailVerificationApiMX): [optional]  # noqa: E501
            syntax_valid (bool): [optional]  # noqa: E501
            message (str): [optional]  # noqa: E501
        """

        _check_type = kwargs.pop('_check_type', True)
        _spec_property_naming = kwargs.pop('_spec_property_naming', False)
        _path_to_item = kwargs.pop('_path_to_item', ())
        _configuration = kwargs.pop('_configuration', None)
        _visited_composed_classes = kwargs.pop('_visited_composed_classes', ())

        if args:
            raise ApiTypeError(
                "Invalid positional arguments=%s passed to %s. Remove those invalid positional arguments." % (
                    args,
                    self.__class__.__name__,
                ),
                path_to_item=_path_to_item,
                valid_classes=(self.__class__,),
            )

        self._data_store = {}
        self._check_type = _check_type
        self._spec_property_naming = _spec_property_naming
        self._path_to_item = _path_to_item
        self._configuration = _configuration
        self._visited_composed_classes = _visited_composed_classes + (self.__class__,)

        constant_args = {
            '_check_type': _check_type,
            '_path_to_item': _path_to_item,
            '_spec_property_naming': _spec_property_naming,
            '_configuration': _configuration,
            '_visited_composed_classes': self._visited_composed_classes,
        }
        required_args = {
        }
        # remove args whose value is Null because they are unset
        required_arg_names = list(required_args.keys())
        for required_arg_name in required_arg_names:
            if required_args[required_arg_name] is nulltype.Null:
                del required_args[required_arg_name]
        model_args = {}
        model_args.update(required_args)
        model_args.update(kwargs)
        composed_info = validate_get_composed_info(
            constant_args, model_args, self)
        self._composed_instances = composed_info[0]
        self._var_name_to_model_instances = composed_info[1]
        self._additional_properties_model_instances = composed_info[2]
        unused_args = composed_info[3]

        for var_name, var_value in required_args.items():
            setattr(self, var_name, var_value)
        for var_name, var_value in kwargs.items():
            if var_name in unused_args and \
                        self._configuration is not None and \
                        self._configuration.discard_unknown_keys and \
                        not self._additional_properties_model_instances:
                # discard variable.
                continue
            setattr(self, var_name, var_value)

    @cached_property
    def _composed_schemas():
        # we need this here to make our import statements work
        # we must store _composed_schemas in here so the code is only run
        # when we invoke this method. If we kept this at the class
        # level we would get an error beause the class level
        # code would be run when this module is imported, and these composed
        # classes don't exist yet because their module has not finished
        # loading
        lazy_import()
        return {
          'anyOf': [
          ],
          'allOf': [
          ],
          'oneOf': [
              CheckIfEmailExistResult,
              MailboxvalidatorResult,
              PromptEmailVerificationApiResult,
          ],
        }
