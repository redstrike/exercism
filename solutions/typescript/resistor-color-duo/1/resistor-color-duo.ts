export function decodedValue(resistorColors: string[]): number {
  const [c1, c2] = resistorColors;
  return parseInt(`${COLORS[c1]}${COLORS[c2]}`);
}

const COLORS: Record<string, number> = {
  black: 0,
  brown: 1,
  red: 2,
  orange: 3,
  yellow: 4,
  green: 5,
  blue: 6,
  violet: 7,
  grey: 8,
  white: 9
};
