@tool
extends EditorPlugin

var button : Button

# === Test Counts ===
var amount_passed : int
var amount_failed : int
var amount_skipped : int

var total_ran : int

# === Names of failed tests ===
var names_failed_array : Array[String]

func _enter_tree() -> void:
	add_control_to_container(EditorPlugin.CONTAINER_TOOLBAR, create_button())

## Creates the button that is used in the editor.
func create_button() -> Button:
	button = Button.new()
	button.text = "Run Tests"
	button.pressed.connect(run_tests)
	return button

## Runs the the chickensoft tests.
func run_tests() -> void:
	print_rich("[color=orange]Make sure you build before running tests![/color]\n\n")
	
	amount_failed = 0
	amount_passed = 0
	amount_skipped = 0
	names_failed_array.clear()
	
	var output : Array
	OS.execute("godot", ["--run-tests", "--quit-on-finish"], output, false, false)
	var output_str : String = output[0]
	var strings : PackedStringArray = output_str.split("\n")
	for item in strings:
		if item.contains("failed"):
			amount_failed += 1
			names_failed_array.append(item)
		if item.contains("passed"):
			amount_passed += 1
		if item.contains("skipped"):
			amount_skipped += 1
	
	print("=== TEST REPORT ===\n\n")
	print("Ran ", amount_passed + amount_failed + amount_skipped, " tests")
	print_rich("[color=green]Passed: ", amount_passed, " | [color=red]Failed: ", amount_failed, " | [color=yellow]Skipped: ", amount_skipped, "[/color]")
	
	if amount_failed != 0:
		print_rich("[color=red]Failed Tests: [/color]")
		for str : String in names_failed_array:
			print("  - ", str)
		print("= For a more detailed failure report, run runtests.bat =")

func _exit_tree() -> void:
	button.queue_free()
	names_failed_array.clear()
	amount_failed = 0
	amount_passed = 0
