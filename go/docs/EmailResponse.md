# EmailResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Input** | Pointer to **string** |  | [optional] 
**IsReachable** | Pointer to **string** |  | [optional] 
**Misc** | Pointer to [**CheckIfEmailExistMisc**](CheckIfEmailExistMisc.md) |  | [optional] 
**Mx** | Pointer to [**CheckIfEmailExistMX**](CheckIfEmailExistMX.md) |  | [optional] 
**Smtp** | Pointer to [**CheckIfEmailExistSMTP**](CheckIfEmailExistSMTP.md) |  | [optional] 
**Syntax** | Pointer to [**CheckIfEmailExistSyntax**](CheckIfEmailExistSyntax.md) |  | [optional] 
**Error** | Pointer to **string** |  | [optional] 
**EmailAddress** | Pointer to **string** |  | [optional] 
**Domain** | Pointer to **string** |  | [optional] 
**IsFree** | Pointer to **string** |  | [optional] 
**IsSyntax** | Pointer to **string** |  | [optional] 
**IsDomain** | Pointer to **string** |  | [optional] 
**IsSmtp** | Pointer to **string** |  | [optional] 
**IsVerified** | Pointer to **string** |  | [optional] 
**IsServerDown** | Pointer to **string** |  | [optional] 
**IsGreylisted** | Pointer to **string** |  | [optional] 
**IsDisposable** | Pointer to **bool** |  | [optional] 
**IsSuppressed** | Pointer to **string** |  | [optional] 
**IsRole** | Pointer to **string** |  | [optional] 
**IsHighRisk** | Pointer to **string** |  | [optional] 
**IsCatchall** | Pointer to **string** |  | [optional] 
**MailboxvalidatorScore** | Pointer to **string** |  | [optional] 
**TimeTaken** | Pointer to **string** |  | [optional] 
**Status** | Pointer to **string** |  | [optional] 
**CreditsAvailable** | Pointer to **int64** |  | [optional] 
**ErrorCode** | Pointer to **string** |  | [optional] 
**ErrorMessage** | Pointer to **string** |  | [optional] 
**CanConnectSmtp** | Pointer to **bool** |  | [optional] 
**Email** | Pointer to **string** |  | [optional] 
**IsCatchAll** | Pointer to **bool** |  | [optional] 
**IsDeliverable** | Pointer to **bool** |  | [optional] 
**IsDisabled** | Pointer to **bool** |  | [optional] 
**IsInboxFull** | Pointer to **bool** |  | [optional] 
**IsRoleAccount** | Pointer to **bool** |  | [optional] 
**MxRecords** | Pointer to [**PromptEmailVerificationApiMX**](PromptEmailVerificationApiMX.md) |  | [optional] 
**SyntaxValid** | Pointer to **bool** |  | [optional] 
**Message** | Pointer to **string** |  | [optional] 

## Methods

### NewEmailResponse

`func NewEmailResponse() *EmailResponse`

NewEmailResponse instantiates a new EmailResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewEmailResponseWithDefaults

`func NewEmailResponseWithDefaults() *EmailResponse`

NewEmailResponseWithDefaults instantiates a new EmailResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetInput

`func (o *EmailResponse) GetInput() string`

GetInput returns the Input field if non-nil, zero value otherwise.

### GetInputOk

`func (o *EmailResponse) GetInputOk() (*string, bool)`

GetInputOk returns a tuple with the Input field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetInput

`func (o *EmailResponse) SetInput(v string)`

SetInput sets Input field to given value.

### HasInput

`func (o *EmailResponse) HasInput() bool`

HasInput returns a boolean if a field has been set.

### GetIsReachable

`func (o *EmailResponse) GetIsReachable() string`

GetIsReachable returns the IsReachable field if non-nil, zero value otherwise.

### GetIsReachableOk

`func (o *EmailResponse) GetIsReachableOk() (*string, bool)`

GetIsReachableOk returns a tuple with the IsReachable field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsReachable

`func (o *EmailResponse) SetIsReachable(v string)`

SetIsReachable sets IsReachable field to given value.

### HasIsReachable

`func (o *EmailResponse) HasIsReachable() bool`

HasIsReachable returns a boolean if a field has been set.

### GetMisc

`func (o *EmailResponse) GetMisc() CheckIfEmailExistMisc`

GetMisc returns the Misc field if non-nil, zero value otherwise.

### GetMiscOk

`func (o *EmailResponse) GetMiscOk() (*CheckIfEmailExistMisc, bool)`

GetMiscOk returns a tuple with the Misc field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMisc

`func (o *EmailResponse) SetMisc(v CheckIfEmailExistMisc)`

SetMisc sets Misc field to given value.

### HasMisc

`func (o *EmailResponse) HasMisc() bool`

HasMisc returns a boolean if a field has been set.

### GetMx

`func (o *EmailResponse) GetMx() CheckIfEmailExistMX`

GetMx returns the Mx field if non-nil, zero value otherwise.

### GetMxOk

`func (o *EmailResponse) GetMxOk() (*CheckIfEmailExistMX, bool)`

GetMxOk returns a tuple with the Mx field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMx

`func (o *EmailResponse) SetMx(v CheckIfEmailExistMX)`

SetMx sets Mx field to given value.

### HasMx

`func (o *EmailResponse) HasMx() bool`

HasMx returns a boolean if a field has been set.

### GetSmtp

`func (o *EmailResponse) GetSmtp() CheckIfEmailExistSMTP`

GetSmtp returns the Smtp field if non-nil, zero value otherwise.

### GetSmtpOk

`func (o *EmailResponse) GetSmtpOk() (*CheckIfEmailExistSMTP, bool)`

GetSmtpOk returns a tuple with the Smtp field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSmtp

`func (o *EmailResponse) SetSmtp(v CheckIfEmailExistSMTP)`

SetSmtp sets Smtp field to given value.

### HasSmtp

`func (o *EmailResponse) HasSmtp() bool`

HasSmtp returns a boolean if a field has been set.

### GetSyntax

`func (o *EmailResponse) GetSyntax() CheckIfEmailExistSyntax`

GetSyntax returns the Syntax field if non-nil, zero value otherwise.

### GetSyntaxOk

`func (o *EmailResponse) GetSyntaxOk() (*CheckIfEmailExistSyntax, bool)`

GetSyntaxOk returns a tuple with the Syntax field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSyntax

`func (o *EmailResponse) SetSyntax(v CheckIfEmailExistSyntax)`

SetSyntax sets Syntax field to given value.

### HasSyntax

`func (o *EmailResponse) HasSyntax() bool`

HasSyntax returns a boolean if a field has been set.

### GetError

`func (o *EmailResponse) GetError() string`

GetError returns the Error field if non-nil, zero value otherwise.

### GetErrorOk

`func (o *EmailResponse) GetErrorOk() (*string, bool)`

GetErrorOk returns a tuple with the Error field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetError

`func (o *EmailResponse) SetError(v string)`

SetError sets Error field to given value.

### HasError

`func (o *EmailResponse) HasError() bool`

HasError returns a boolean if a field has been set.

### GetEmailAddress

`func (o *EmailResponse) GetEmailAddress() string`

GetEmailAddress returns the EmailAddress field if non-nil, zero value otherwise.

### GetEmailAddressOk

`func (o *EmailResponse) GetEmailAddressOk() (*string, bool)`

GetEmailAddressOk returns a tuple with the EmailAddress field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmailAddress

`func (o *EmailResponse) SetEmailAddress(v string)`

SetEmailAddress sets EmailAddress field to given value.

### HasEmailAddress

`func (o *EmailResponse) HasEmailAddress() bool`

HasEmailAddress returns a boolean if a field has been set.

### GetDomain

`func (o *EmailResponse) GetDomain() string`

GetDomain returns the Domain field if non-nil, zero value otherwise.

### GetDomainOk

`func (o *EmailResponse) GetDomainOk() (*string, bool)`

GetDomainOk returns a tuple with the Domain field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetDomain

`func (o *EmailResponse) SetDomain(v string)`

SetDomain sets Domain field to given value.

### HasDomain

`func (o *EmailResponse) HasDomain() bool`

HasDomain returns a boolean if a field has been set.

### GetIsFree

`func (o *EmailResponse) GetIsFree() string`

GetIsFree returns the IsFree field if non-nil, zero value otherwise.

### GetIsFreeOk

`func (o *EmailResponse) GetIsFreeOk() (*string, bool)`

GetIsFreeOk returns a tuple with the IsFree field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsFree

`func (o *EmailResponse) SetIsFree(v string)`

SetIsFree sets IsFree field to given value.

### HasIsFree

`func (o *EmailResponse) HasIsFree() bool`

HasIsFree returns a boolean if a field has been set.

### GetIsSyntax

`func (o *EmailResponse) GetIsSyntax() string`

GetIsSyntax returns the IsSyntax field if non-nil, zero value otherwise.

### GetIsSyntaxOk

`func (o *EmailResponse) GetIsSyntaxOk() (*string, bool)`

GetIsSyntaxOk returns a tuple with the IsSyntax field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsSyntax

`func (o *EmailResponse) SetIsSyntax(v string)`

SetIsSyntax sets IsSyntax field to given value.

### HasIsSyntax

`func (o *EmailResponse) HasIsSyntax() bool`

HasIsSyntax returns a boolean if a field has been set.

### GetIsDomain

`func (o *EmailResponse) GetIsDomain() string`

GetIsDomain returns the IsDomain field if non-nil, zero value otherwise.

### GetIsDomainOk

`func (o *EmailResponse) GetIsDomainOk() (*string, bool)`

GetIsDomainOk returns a tuple with the IsDomain field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsDomain

`func (o *EmailResponse) SetIsDomain(v string)`

SetIsDomain sets IsDomain field to given value.

### HasIsDomain

`func (o *EmailResponse) HasIsDomain() bool`

HasIsDomain returns a boolean if a field has been set.

### GetIsSmtp

`func (o *EmailResponse) GetIsSmtp() string`

GetIsSmtp returns the IsSmtp field if non-nil, zero value otherwise.

### GetIsSmtpOk

`func (o *EmailResponse) GetIsSmtpOk() (*string, bool)`

GetIsSmtpOk returns a tuple with the IsSmtp field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsSmtp

`func (o *EmailResponse) SetIsSmtp(v string)`

SetIsSmtp sets IsSmtp field to given value.

### HasIsSmtp

`func (o *EmailResponse) HasIsSmtp() bool`

HasIsSmtp returns a boolean if a field has been set.

### GetIsVerified

`func (o *EmailResponse) GetIsVerified() string`

GetIsVerified returns the IsVerified field if non-nil, zero value otherwise.

### GetIsVerifiedOk

`func (o *EmailResponse) GetIsVerifiedOk() (*string, bool)`

GetIsVerifiedOk returns a tuple with the IsVerified field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsVerified

`func (o *EmailResponse) SetIsVerified(v string)`

SetIsVerified sets IsVerified field to given value.

### HasIsVerified

`func (o *EmailResponse) HasIsVerified() bool`

HasIsVerified returns a boolean if a field has been set.

### GetIsServerDown

`func (o *EmailResponse) GetIsServerDown() string`

GetIsServerDown returns the IsServerDown field if non-nil, zero value otherwise.

### GetIsServerDownOk

`func (o *EmailResponse) GetIsServerDownOk() (*string, bool)`

GetIsServerDownOk returns a tuple with the IsServerDown field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsServerDown

`func (o *EmailResponse) SetIsServerDown(v string)`

SetIsServerDown sets IsServerDown field to given value.

### HasIsServerDown

`func (o *EmailResponse) HasIsServerDown() bool`

HasIsServerDown returns a boolean if a field has been set.

### GetIsGreylisted

`func (o *EmailResponse) GetIsGreylisted() string`

GetIsGreylisted returns the IsGreylisted field if non-nil, zero value otherwise.

### GetIsGreylistedOk

`func (o *EmailResponse) GetIsGreylistedOk() (*string, bool)`

GetIsGreylistedOk returns a tuple with the IsGreylisted field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsGreylisted

`func (o *EmailResponse) SetIsGreylisted(v string)`

SetIsGreylisted sets IsGreylisted field to given value.

### HasIsGreylisted

`func (o *EmailResponse) HasIsGreylisted() bool`

HasIsGreylisted returns a boolean if a field has been set.

### GetIsDisposable

`func (o *EmailResponse) GetIsDisposable() bool`

GetIsDisposable returns the IsDisposable field if non-nil, zero value otherwise.

### GetIsDisposableOk

`func (o *EmailResponse) GetIsDisposableOk() (*bool, bool)`

GetIsDisposableOk returns a tuple with the IsDisposable field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsDisposable

`func (o *EmailResponse) SetIsDisposable(v bool)`

SetIsDisposable sets IsDisposable field to given value.

### HasIsDisposable

`func (o *EmailResponse) HasIsDisposable() bool`

HasIsDisposable returns a boolean if a field has been set.

### GetIsSuppressed

`func (o *EmailResponse) GetIsSuppressed() string`

GetIsSuppressed returns the IsSuppressed field if non-nil, zero value otherwise.

### GetIsSuppressedOk

`func (o *EmailResponse) GetIsSuppressedOk() (*string, bool)`

GetIsSuppressedOk returns a tuple with the IsSuppressed field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsSuppressed

`func (o *EmailResponse) SetIsSuppressed(v string)`

SetIsSuppressed sets IsSuppressed field to given value.

### HasIsSuppressed

`func (o *EmailResponse) HasIsSuppressed() bool`

HasIsSuppressed returns a boolean if a field has been set.

### GetIsRole

`func (o *EmailResponse) GetIsRole() string`

GetIsRole returns the IsRole field if non-nil, zero value otherwise.

### GetIsRoleOk

`func (o *EmailResponse) GetIsRoleOk() (*string, bool)`

GetIsRoleOk returns a tuple with the IsRole field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsRole

`func (o *EmailResponse) SetIsRole(v string)`

SetIsRole sets IsRole field to given value.

### HasIsRole

`func (o *EmailResponse) HasIsRole() bool`

HasIsRole returns a boolean if a field has been set.

### GetIsHighRisk

`func (o *EmailResponse) GetIsHighRisk() string`

GetIsHighRisk returns the IsHighRisk field if non-nil, zero value otherwise.

### GetIsHighRiskOk

`func (o *EmailResponse) GetIsHighRiskOk() (*string, bool)`

GetIsHighRiskOk returns a tuple with the IsHighRisk field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsHighRisk

`func (o *EmailResponse) SetIsHighRisk(v string)`

SetIsHighRisk sets IsHighRisk field to given value.

### HasIsHighRisk

`func (o *EmailResponse) HasIsHighRisk() bool`

HasIsHighRisk returns a boolean if a field has been set.

### GetIsCatchall

`func (o *EmailResponse) GetIsCatchall() string`

GetIsCatchall returns the IsCatchall field if non-nil, zero value otherwise.

### GetIsCatchallOk

`func (o *EmailResponse) GetIsCatchallOk() (*string, bool)`

GetIsCatchallOk returns a tuple with the IsCatchall field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsCatchall

`func (o *EmailResponse) SetIsCatchall(v string)`

SetIsCatchall sets IsCatchall field to given value.

### HasIsCatchall

`func (o *EmailResponse) HasIsCatchall() bool`

HasIsCatchall returns a boolean if a field has been set.

### GetMailboxvalidatorScore

`func (o *EmailResponse) GetMailboxvalidatorScore() string`

GetMailboxvalidatorScore returns the MailboxvalidatorScore field if non-nil, zero value otherwise.

### GetMailboxvalidatorScoreOk

`func (o *EmailResponse) GetMailboxvalidatorScoreOk() (*string, bool)`

GetMailboxvalidatorScoreOk returns a tuple with the MailboxvalidatorScore field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMailboxvalidatorScore

`func (o *EmailResponse) SetMailboxvalidatorScore(v string)`

SetMailboxvalidatorScore sets MailboxvalidatorScore field to given value.

### HasMailboxvalidatorScore

`func (o *EmailResponse) HasMailboxvalidatorScore() bool`

HasMailboxvalidatorScore returns a boolean if a field has been set.

### GetTimeTaken

`func (o *EmailResponse) GetTimeTaken() string`

GetTimeTaken returns the TimeTaken field if non-nil, zero value otherwise.

### GetTimeTakenOk

`func (o *EmailResponse) GetTimeTakenOk() (*string, bool)`

GetTimeTakenOk returns a tuple with the TimeTaken field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetTimeTaken

`func (o *EmailResponse) SetTimeTaken(v string)`

SetTimeTaken sets TimeTaken field to given value.

### HasTimeTaken

`func (o *EmailResponse) HasTimeTaken() bool`

HasTimeTaken returns a boolean if a field has been set.

### GetStatus

`func (o *EmailResponse) GetStatus() string`

GetStatus returns the Status field if non-nil, zero value otherwise.

### GetStatusOk

`func (o *EmailResponse) GetStatusOk() (*string, bool)`

GetStatusOk returns a tuple with the Status field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStatus

`func (o *EmailResponse) SetStatus(v string)`

SetStatus sets Status field to given value.

### HasStatus

`func (o *EmailResponse) HasStatus() bool`

HasStatus returns a boolean if a field has been set.

### GetCreditsAvailable

`func (o *EmailResponse) GetCreditsAvailable() int64`

GetCreditsAvailable returns the CreditsAvailable field if non-nil, zero value otherwise.

### GetCreditsAvailableOk

`func (o *EmailResponse) GetCreditsAvailableOk() (*int64, bool)`

GetCreditsAvailableOk returns a tuple with the CreditsAvailable field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCreditsAvailable

`func (o *EmailResponse) SetCreditsAvailable(v int64)`

SetCreditsAvailable sets CreditsAvailable field to given value.

### HasCreditsAvailable

`func (o *EmailResponse) HasCreditsAvailable() bool`

HasCreditsAvailable returns a boolean if a field has been set.

### GetErrorCode

`func (o *EmailResponse) GetErrorCode() string`

GetErrorCode returns the ErrorCode field if non-nil, zero value otherwise.

### GetErrorCodeOk

`func (o *EmailResponse) GetErrorCodeOk() (*string, bool)`

GetErrorCodeOk returns a tuple with the ErrorCode field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetErrorCode

`func (o *EmailResponse) SetErrorCode(v string)`

SetErrorCode sets ErrorCode field to given value.

### HasErrorCode

`func (o *EmailResponse) HasErrorCode() bool`

HasErrorCode returns a boolean if a field has been set.

### GetErrorMessage

`func (o *EmailResponse) GetErrorMessage() string`

GetErrorMessage returns the ErrorMessage field if non-nil, zero value otherwise.

### GetErrorMessageOk

`func (o *EmailResponse) GetErrorMessageOk() (*string, bool)`

GetErrorMessageOk returns a tuple with the ErrorMessage field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetErrorMessage

`func (o *EmailResponse) SetErrorMessage(v string)`

SetErrorMessage sets ErrorMessage field to given value.

### HasErrorMessage

`func (o *EmailResponse) HasErrorMessage() bool`

HasErrorMessage returns a boolean if a field has been set.

### GetCanConnectSmtp

`func (o *EmailResponse) GetCanConnectSmtp() bool`

GetCanConnectSmtp returns the CanConnectSmtp field if non-nil, zero value otherwise.

### GetCanConnectSmtpOk

`func (o *EmailResponse) GetCanConnectSmtpOk() (*bool, bool)`

GetCanConnectSmtpOk returns a tuple with the CanConnectSmtp field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetCanConnectSmtp

`func (o *EmailResponse) SetCanConnectSmtp(v bool)`

SetCanConnectSmtp sets CanConnectSmtp field to given value.

### HasCanConnectSmtp

`func (o *EmailResponse) HasCanConnectSmtp() bool`

HasCanConnectSmtp returns a boolean if a field has been set.

### GetEmail

`func (o *EmailResponse) GetEmail() string`

GetEmail returns the Email field if non-nil, zero value otherwise.

### GetEmailOk

`func (o *EmailResponse) GetEmailOk() (*string, bool)`

GetEmailOk returns a tuple with the Email field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetEmail

`func (o *EmailResponse) SetEmail(v string)`

SetEmail sets Email field to given value.

### HasEmail

`func (o *EmailResponse) HasEmail() bool`

HasEmail returns a boolean if a field has been set.

### GetIsCatchAll

`func (o *EmailResponse) GetIsCatchAll() bool`

GetIsCatchAll returns the IsCatchAll field if non-nil, zero value otherwise.

### GetIsCatchAllOk

`func (o *EmailResponse) GetIsCatchAllOk() (*bool, bool)`

GetIsCatchAllOk returns a tuple with the IsCatchAll field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsCatchAll

`func (o *EmailResponse) SetIsCatchAll(v bool)`

SetIsCatchAll sets IsCatchAll field to given value.

### HasIsCatchAll

`func (o *EmailResponse) HasIsCatchAll() bool`

HasIsCatchAll returns a boolean if a field has been set.

### GetIsDeliverable

`func (o *EmailResponse) GetIsDeliverable() bool`

GetIsDeliverable returns the IsDeliverable field if non-nil, zero value otherwise.

### GetIsDeliverableOk

`func (o *EmailResponse) GetIsDeliverableOk() (*bool, bool)`

GetIsDeliverableOk returns a tuple with the IsDeliverable field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsDeliverable

`func (o *EmailResponse) SetIsDeliverable(v bool)`

SetIsDeliverable sets IsDeliverable field to given value.

### HasIsDeliverable

`func (o *EmailResponse) HasIsDeliverable() bool`

HasIsDeliverable returns a boolean if a field has been set.

### GetIsDisabled

`func (o *EmailResponse) GetIsDisabled() bool`

GetIsDisabled returns the IsDisabled field if non-nil, zero value otherwise.

### GetIsDisabledOk

`func (o *EmailResponse) GetIsDisabledOk() (*bool, bool)`

GetIsDisabledOk returns a tuple with the IsDisabled field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsDisabled

`func (o *EmailResponse) SetIsDisabled(v bool)`

SetIsDisabled sets IsDisabled field to given value.

### HasIsDisabled

`func (o *EmailResponse) HasIsDisabled() bool`

HasIsDisabled returns a boolean if a field has been set.

### GetIsInboxFull

`func (o *EmailResponse) GetIsInboxFull() bool`

GetIsInboxFull returns the IsInboxFull field if non-nil, zero value otherwise.

### GetIsInboxFullOk

`func (o *EmailResponse) GetIsInboxFullOk() (*bool, bool)`

GetIsInboxFullOk returns a tuple with the IsInboxFull field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsInboxFull

`func (o *EmailResponse) SetIsInboxFull(v bool)`

SetIsInboxFull sets IsInboxFull field to given value.

### HasIsInboxFull

`func (o *EmailResponse) HasIsInboxFull() bool`

HasIsInboxFull returns a boolean if a field has been set.

### GetIsRoleAccount

`func (o *EmailResponse) GetIsRoleAccount() bool`

GetIsRoleAccount returns the IsRoleAccount field if non-nil, zero value otherwise.

### GetIsRoleAccountOk

`func (o *EmailResponse) GetIsRoleAccountOk() (*bool, bool)`

GetIsRoleAccountOk returns a tuple with the IsRoleAccount field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetIsRoleAccount

`func (o *EmailResponse) SetIsRoleAccount(v bool)`

SetIsRoleAccount sets IsRoleAccount field to given value.

### HasIsRoleAccount

`func (o *EmailResponse) HasIsRoleAccount() bool`

HasIsRoleAccount returns a boolean if a field has been set.

### GetMxRecords

`func (o *EmailResponse) GetMxRecords() PromptEmailVerificationApiMX`

GetMxRecords returns the MxRecords field if non-nil, zero value otherwise.

### GetMxRecordsOk

`func (o *EmailResponse) GetMxRecordsOk() (*PromptEmailVerificationApiMX, bool)`

GetMxRecordsOk returns a tuple with the MxRecords field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMxRecords

`func (o *EmailResponse) SetMxRecords(v PromptEmailVerificationApiMX)`

SetMxRecords sets MxRecords field to given value.

### HasMxRecords

`func (o *EmailResponse) HasMxRecords() bool`

HasMxRecords returns a boolean if a field has been set.

### GetSyntaxValid

`func (o *EmailResponse) GetSyntaxValid() bool`

GetSyntaxValid returns the SyntaxValid field if non-nil, zero value otherwise.

### GetSyntaxValidOk

`func (o *EmailResponse) GetSyntaxValidOk() (*bool, bool)`

GetSyntaxValidOk returns a tuple with the SyntaxValid field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSyntaxValid

`func (o *EmailResponse) SetSyntaxValid(v bool)`

SetSyntaxValid sets SyntaxValid field to given value.

### HasSyntaxValid

`func (o *EmailResponse) HasSyntaxValid() bool`

HasSyntaxValid returns a boolean if a field has been set.

### GetMessage

`func (o *EmailResponse) GetMessage() string`

GetMessage returns the Message field if non-nil, zero value otherwise.

### GetMessageOk

`func (o *EmailResponse) GetMessageOk() (*string, bool)`

GetMessageOk returns a tuple with the Message field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMessage

`func (o *EmailResponse) SetMessage(v string)`

SetMessage sets Message field to given value.

### HasMessage

`func (o *EmailResponse) HasMessage() bool`

HasMessage returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


