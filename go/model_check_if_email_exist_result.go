/*
 * Email Validator
 *
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds.
 *
 * API version: 0.0.1
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type CheckIfEmailExistResult struct {
	Input       string                   `json:"input,omitempty"`
	IsReachable string                   `json:"is_reachable,omitempty"`
	Misc        *CheckIfEmailExistMisc   `json:"misc,omitempty"`
	Mx          *CheckIfEmailExistMx     `json:"mx,omitempty"`
	Smtp        *CheckIfEmailExistSmtp   `json:"smtp,omitempty"`
	Syntax      *CheckIfEmailExistSyntax `json:"syntax,omitempty"`
	Error_      string                   `json:"error,omitempty"`
}
